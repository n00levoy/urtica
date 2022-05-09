namespace Urtica.CLI;

using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.IO;

internal class CommandBuilder
{
    public Command CreateCommand(ICommandHandler commandHandler)
    {
        var command = new RootCommand
        {
            Handler = CommandHandler.Create(commandHandler.HandleCommand),
        };

        this.AddOptions(command);

        return command;
    }

    private void AddOptions(Command command)
    {
        command.AddOption(this.CreateInputOption());
    }

    private Option<FileInfo> CreateInputOption()
    {
        var option = new Option<FileInfo>("--input")
        {
            Description = "Input file path",
            Arity = ArgumentArity.OneOrMore,
        };
        option.AddAlias("-i");

        return option;
    }
}