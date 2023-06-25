int result = AskForNumberInRange("Input any number that you want!", 0, 100);


int AskForNumber(string text)
{
    Console.Write(text);
    int response = Convert.ToInt32(Console.ReadLine());
    return response;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number <= max)
            return number;
        Console.WriteLine("Try Again");
    }
}
