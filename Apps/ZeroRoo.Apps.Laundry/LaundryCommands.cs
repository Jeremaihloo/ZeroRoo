using System;
using ZeroRoo.Commands;
using ZeroRoo.Laundry15.Models;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.ComponentModel;

namespace ZeroRoo.Apps.Laundry
{
    public class LaundryCommands : DefaultCommandHandler
    {

        public LaundryCommands()
        {

        }

        [CommandName("render forms")]
        public void RenderForms()
        {
            var results = new List<object>();

            var models = new List<Type>();
            models.Add(typeof(Brand));
            models.Add(typeof(ClotheCategory));
            models.Add(typeof(Color));
            models.Add(typeof(FeeRecord));
            models.Add(typeof(Flaw));
            models.Add(typeof(LaundryTicket));
            models.Add(typeof(PayType));
            models.Add(typeof(Price));
            models.Add(typeof(TicketClotheRecord));
            models.Add(typeof(UserProfile));

            var m_schema = new List<object>();

            foreach (var model in models)
            {
                var schema = this.GetModelSchema(model);
                m_schema.Add(new
                {
                    name = model.Name,
                    fields = schema
                });
            }
            results.Add(m_schema);
            Console.WriteLine(JsonConvert.SerializeObject(m_schema, Formatting.Indented));
        }

        private object GetModelSchema(Type model)
        {
            var schema = new List<object>();
            var props = model.GetProperties();
            foreach (var p in props)
            {
                if (p.PropertyType == typeof(DateTime))
                {
                    schema.Add(new
                    {
                        type = "date",
                        label = this.GetLabel(p),
                        model = $"{model.Name}.{p.Name}",
                        required = true
                    });
                }
                else if (p.PropertyType == typeof(Enum))
                {
                    schema.Add(new
                    {
                        type = "select",
                        label = this.GetLabel(p),
                        model = $"{model.Name}.{p.Name}",
                        required = true
                    });
                }
                else
                {
                    schema.Add(new
                    {
                        type = "input",
                        inputType = "text",
                        label = this.GetLabel(p),
                        model = $"{model.Name}.{p.Name}",
                        required = true
                    });
                }
            }
            return schema;
        }

        private string GetLabel(PropertyInfo p)
        {
            object[] objs = p.GetCustomAttributes(typeof(DescriptionAttribute), true);
            if (objs.Length > 0)
            {
                return ((DescriptionAttribute)objs[0]).Description;
            }
            return "";
        }
    }
}
