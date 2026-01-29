using Spectre.Console;
using Spectre.Console.Cli;
using System.ComponentModel;

namespace MyTuiApp.Commands;

public sealed class HelloCommand : Command<HelloCommand.Settings>
{
    public sealed class Settings : CommandSettings
    {
        [Description("Name to greet")]
        [CommandArgument(0, "[name]")]
        public string Name { get; init; } = "World";

        [Description("Use fancy styling")]
        [CommandOption("-f|--fancy")]
        public bool Fancy { get; init; }
    }

    public override int Execute(CommandContext context, Settings settings)
    {
        if (settings.Fancy)
        {
            AnsiConsole.Write(
                new FigletText("Hello!")
                    .Centered()
                    .Color(Color.Green));
            
            AnsiConsole.MarkupLine($"[bold cyan]Welcome, {settings.Name}![/]");
        }
        else
        {
            AnsiConsole.MarkupLine($"Hello, [green]{settings.Name}[/]!");
        }

        return 0;
    }
}
