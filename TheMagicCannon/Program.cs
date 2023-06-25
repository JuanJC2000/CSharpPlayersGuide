for(int x=1;  x <= 100; x++)
{
    //Console.WriteLine(x);
    //Remember that the conditional with the most conditions, i.e the most complex one has to go on top as to make sure that it is always checked first before checking our lesser ones. Basically, since  %3 and %5 are individual conditions inside the else if's and would mean that our first statement is already null, thus it is not a factor of 5 and 3, but a factor of 5 OR 3.
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