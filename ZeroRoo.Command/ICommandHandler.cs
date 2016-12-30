using System.Threading.Tasks;

namespace ZeroRoo.Commands
{
    public interface ICommandHandler
    {
        Task ExecuteAsync(CommandContext context);
    }
}