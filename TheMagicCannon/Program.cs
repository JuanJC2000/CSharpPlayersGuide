for(int x=1;  x <= 100; x++)
{
    //Console.WriteLine(x);
    if (x % 3 == 0 && x % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{x}: Fire and Electric");
    }

    else if (x % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{x}: Fire");
    }
    else if (x % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{x}: Electric");
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"{x}: Normal");
    }

    Console.ForegroundColor = ConsoleColor.White;
}