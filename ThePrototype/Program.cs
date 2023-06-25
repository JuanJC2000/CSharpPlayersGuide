//save return variable from AskForNumberInRange inside global variable name 'number'.
int number = AskForNumberInRange("User 1, enter a number between 0 and 100: ", 0, 100); //Method takes data text, min int, and max int.
Console.Clear();

Console.WriteLine("User 2, guess the number.");

while (true)
{
    int guess = AskForNumber("What is your next guess?: ");
    if (guess > number) Console.WriteLine($"{guess} is too high.");
    else if (guess < number) Console.WriteLine($"{guess} is too low.");
    else break;
}

Console.WriteLine("You guessed the number!");


///<summary>
///AskForNumber
///</summary>
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


