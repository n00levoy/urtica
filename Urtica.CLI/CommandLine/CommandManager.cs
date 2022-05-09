namespace Urtica.CLI;

using System;
using System.CommandLine;
using System.CommandLine.IO;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Handles command execution pipeline.
/// </summary>
internal class CommandManager : ICommandHandler
{
    private readonly CommandBuilder commandBuilder;

    /// <summary>
    /// Initializes a new instance of the <see cref="CommandManager"/> class.
    /// </summary>
    /// <param name="commandBuilder">Builder to create command from arguments.</param>
    public CommandManager(CommandBuilder commandBuilder)
    {
        this.commandBuilder = commandBuilder;
    }

    public async Task<int> ProcessCommand(string[] args)
    {
        return await this.commandBuilder.CreateCommand(this).InvokeAsync(args);
    }

    /// <inheritdoc/>
    async Task<int> ICommandHandler.HandleCommand(CommandOptions options, IConsole console, CancellationToken token)
    {
        try
        {
            await this.RunCommand(options);
            return 0;
        }
        catch (OperationCanceledException)
        {
            console.Error.WriteLine("The operation was aborted by user!");
            return 1;
        }
    }

    private async Task RunCommand(CommandOptions options)
    {
    }
}