using Spectre.Console;
using Spectre.Console.Cli;
using MyTuiApp.Commands;

var app = new CommandApp();
app.Configure(config =>
{
    config.SetApplicationName("mytui");
    
    // Example command registration
    config.AddCommand<HelloCommand>("hello")
        .WithDescription("Display a hello message");
});

return app.Run(args);
