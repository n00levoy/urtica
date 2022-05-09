namespace Urtica.CLI;

using System.Threading.Tasks;
using Autofac;

/// <summary>
/// CLI program entry point.
/// </summary>
internal static class Program
{
    private static IContainer Container { get; set; }

    private static async Task<int> Main(string[] args)
    {
        Container = ComposeContainer();

        await using var scope = Container.BeginLifetimeScope();
        var commandManager = scope.Resolve<CommandManager>();
        return await commandManager.ProcessCommand(args);
    }

    private static IContainer ComposeContainer()
    {
        var containerBuilder = new ContainerBuilder();
        containerBuilder.RegisterType<CommandManager>();
        containerBuilder.RegisterType<CommandBuilder>();

        return containerBuilder.Build();
    }
}