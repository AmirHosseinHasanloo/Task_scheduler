while (true)
{
    Console.WriteLine("you can use --help to get the list of all commands.");
    var command = Console.ReadLine();

    if (command == "--help")
    {
        System.Console.WriteLine("--create");
    }


    if (command == "--exit")
    {
        System.Console.WriteLine("--create");
    }
}