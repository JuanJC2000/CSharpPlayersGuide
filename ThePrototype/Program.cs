int chosenNumber;
bool numberIsRight = false;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    chosenNumber = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    

}
while (chosenNumber < 0 || chosenNumber > 100);

Console.Clear();
Console.WriteLine("User 2, guess the number.");

do
{
    Console.Write("What is your next guess? ");
    int whichNumber = Convert.ToInt32(Console.ReadLine());

    if (whichNumber == chosenNumber)
    {
        Console.WriteLine("You guessed the number.");
        break;
    }
       

    else if (whichNumber > chosenNumber)
        Console.WriteLine($"{whichNumber} is too high.");
    else if (whichNumber < chosenNumber)
        Console.WriteLine($"{whichNumber} is too low.");

    /*
    whichNumber = chosenNumber switch
    {
        whichNumber == chosenNumber => "You guessed the number.",
        whichNumber > chosenNumber => $"{whichNumber} is too high.",
        whichNumber < chosenNumber => $"{whichNumber} is too low."





    };
    */



}
while (true);

