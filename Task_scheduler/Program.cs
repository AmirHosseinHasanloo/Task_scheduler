namespace Task_scheduler;

using Command;

class Program
{
    readonly ICommand _command;

    Program(ICommand command)
    {
        this._command = command;
    }

    async Task RunAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            Console.WriteLine("Enter command (type --help for options):");
            await _command.RunCommandAsync(cancellationToken);
        }
    }

    static async Task Main()
    {
        using var cancellationToken = new CancellationTokenSource();

        Console.CancelKeyPress += (_, e) =>
        {
            e.Cancel = true;
            cancellationToken.Cancel();
        };

        var runner = new Task_scheduler.Command.Command();
        var app = new Program(runner);

        await app.RunAsync(cancellationToken.Token);

        Console.WriteLine("Program exited gracefully.");
    }
}