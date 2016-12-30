using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ZeroRoo.Commands
{
    public abstract class DefaultCommandHandler : ICommandHandler
    {
        protected DefaultCommandHandler()
        {
            
        }
        
        public CommandContext Context { get; set; }

        public Task ExecuteAsync(CommandContext context)
        {
            SetSwitchValues(context);
            return InvokeAsync(context);
        }

        private void SetSwitchValues(CommandContext context)
        {
            if (context.Switches != null && context.Switches.Count > 0)
            {
                foreach (var commandSwitch in context.Switches)
                {
                    SetSwitchValue(commandSwitch);
                }
            }
        }

        private void SetSwitchValue(KeyValuePair<string, string> commandSwitch)
        {
            // Find the property
            var type = GetType();
            PropertyInfo propertyInfo = GetType().GetProperty(commandSwitch.Key, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase);
            if (propertyInfo == null)
            {
                throw new InvalidOperationException(string.Format("Switch \"{0}\" was not found", commandSwitch.Key));
            }
            if (!propertyInfo.GetCustomAttributes(typeof(CommandSwitchAttribute), false).Any())
            {
                throw new InvalidOperationException(string.Format("A property \"{0}\" exists but is not decorated with \"{1}\"", commandSwitch.Key, typeof(CommandSwitchAttribute).Name));
            }

            // Set the value
            try
            {
                object value = ConvertToType(propertyInfo.PropertyType, commandSwitch.Value);
                propertyInfo.SetValue(this, value, null /*index*/);
            }
            catch (Exception ex)
            {
                //TODO: (ngm) fix this message
                string message = string.Format("Error converting value \"{0}\" to \"{1}\" for switch \"{2}\"",
                    commandSwitch.Value,
                    propertyInfo.PropertyType.FullName,
                    commandSwitch.Key);
                throw new InvalidOperationException(message, ex);
            }
        }


        private async Task InvokeAsync(CommandContext context)
        {
            CheckMethodForSwitches(context.CommandDescriptor.MethodInfo, context.Switches);

            var arguments = (context.Arguments ?? Enumerable.Empty<string>()).ToArray();
            object[] invokeParameters = GetInvokeParametersForMethod(context.CommandDescriptor.MethodInfo, arguments);
            if (invokeParameters == null)
            {
                throw new InvalidOperationException(string.Format("Command arguments \"{0}\" don't match command definition", string.Join(" ", arguments)));
            }

            this.Context = context;
            var result = context.CommandDescriptor.MethodInfo.Invoke(this, invokeParameters);
            if (result is string)
            {
                await context.Output.WriteAsync(result.ToString());
            }
        }

        private static object[] GetInvokeParametersForMethod(MethodInfo methodInfo, IList<string> arguments)
        {
            var invokeParameters = new List<object>();
            var args = new List<string>(arguments);
            var methodParameters = methodInfo.GetParameters();
            bool methodHasParams = false;

            if (methodParameters.Length == 0)
            {
                if (args.Count == 0)
                {
                    return invokeParameters.ToArray();
                }
                return null;
            }

            if (methodParameters[methodParameters.Length - 1].ParameterType.IsAssignableFrom(typeof(string[])))
            {
                methodHasParams = true;
            }

            var requiredMethodParameters = methodParameters.Where(x => !x.HasDefaultValue).ToArray();

            if (!methodHasParams && args.Count < requiredMethodParameters.Length) return null;
            if (methodHasParams && (methodParameters.Length - args.Count >= 2)) return null;

            for (int i = 0; i < methodParameters.Length; i++)
            {
                if (methodParameters[i].ParameterType.IsAssignableFrom(typeof(string[])))
                {
                    invokeParameters.Add(args.GetRange(i, args.Count - i).ToArray());
                    break;
                }

                if (i < arguments.Count)
                {
                    var val = ConvertToType(methodParameters[i].ParameterType, arguments[i]);
                    if (val == null) return null;

                    invokeParameters.Add(val);
                }
                else
                {
                    invokeParameters.Add(methodParameters[i].DefaultValue);
                }
            }

            if (methodHasParams && (methodParameters.Length - args.Count == 1)) invokeParameters.Add(new string[] { });

            return invokeParameters.ToArray();
        }

        private void CheckMethodForSwitches(MethodInfo methodInfo, IDictionary<string, string> switches)
        {
            if (switches == null || switches.Count == 0)
                return;

            var supportedSwitches = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (CommandSwitchesAttribute switchesAttribute in methodInfo.GetCustomAttributes(typeof(CommandSwitchesAttribute), false))
            {
                supportedSwitches.UnionWith(switchesAttribute.Switches);
            }

            foreach (var commandSwitch in switches.Keys)
            {
                if (!supportedSwitches.Contains(commandSwitch))
                {
                    throw new InvalidOperationException(string.Format("Method \"{0}\" does not support switch \"{1}\".", methodInfo.Name, commandSwitch));
                }
            }
        }

        private static object ConvertToType(Type type, string value)
        {
            if (type.GetTypeInfo().IsEnum)
            {
                try
                {
                    return Enum.Parse(type, value, true);
                }
                catch (ArgumentException)
                {
                    return null;
                }
            }
            else
            {
                return Convert.ChangeType(value, type);
            }
        }
    }
}