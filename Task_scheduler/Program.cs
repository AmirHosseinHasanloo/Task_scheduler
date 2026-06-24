using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Task_scheduler.Context;

var services = new ServiceCollection();

services.AddDbContext<DataBaseContext>(options =>

{

    options.UseSqlite("Data Source=app.db");

});

var provider = services.BuildServiceProvider();

using var scope = provider.CreateScope();

var db = scope.ServiceProvider.GetRequiredService<DataBaseContext>();

db.Database.EnsureCreated();

Console.WriteLine("Database Created Successfully!");

while (true)
{
    Console.WriteLine("you can use --help to get the list of all commands.");
    var command = Console.ReadLine();

    if (command == "--help")
    {
        Console.WriteLine("--create");
    }

    if (command == "--exit")
    {
        Console.WriteLine("--create");
    }
}