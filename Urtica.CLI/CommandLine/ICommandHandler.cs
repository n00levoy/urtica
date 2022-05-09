namespace Urtica.CLI;

using System.CommandLine;
using System.Threading;
using System.Threading.Tasks;

public interface ICommandHandler
{
    Task<int> HandleCommand(CommandOptions options, IConsole console, CancellationToken token);
}