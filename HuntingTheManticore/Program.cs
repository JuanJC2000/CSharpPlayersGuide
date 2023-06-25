//Setup the game
int manticoreHP = 10;
int cityHP = 15;
int currentRound = 1;

// Get the starting distance for the Manticore
int manticoreDistance = AskForNumberInRange("Player 1: Choose the manticores distance from the city: ", 0, 100);
Console.Clear();

Console.WriteLine("Player 2, it is your turn");

//Run the game until we break out the loop, could have used conditionals but instead i opted for breaks.
while (true)
{
    //Display current stats for the round.
    DisplayCurrentStats(currentRound, cityHP, manticoreHP);

    //Computes and displays how much damage is expected for this round
    int damage = ComputeDamage(currentRound);
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

    //Get a number from the player 
    int targetRange = AskForNumber("Enter desired cannon range: ");

    //Display outcome of number and apply damage 
    int takenDamage = TargetRangeToDamage(targetRange, manticoreDistance, damage);
    manticoreHP -= takenDamage; //Manticore will not take damage unless it is a direct hit thanks to our TargetRangeToDamage local function
    if (manticoreHP > 0) //reduce health of city by 1 if manticore is still alive
        cityHP--;

    currentRound++; //Increase round counter by 1 each time through loop

    //Our win and lose states, which exit the loop after printing out the result 
    if (manticoreHP <= 0)
    {
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        break;
    }
        
    else if (cityHP <= 0)
    {
        Console.WriteLine("The Manticore destoyed the city, you lose.");
        break;
    }
        


}

//Asks for a number and returns that number 
int AskForNumber(string text)
{
    Console.Write(text);
    int response = Convert.ToInt32(Console.ReadLine());
    return response;
}

//Uses our askfornumber function to save the returned number and compare it with conditionals, and then returning the number if it matches what we want
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

//Displays current stats of the game
void DisplayCurrentStats(int round, int cHealth, int mHealth)
{
    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round}  City: {cHealth}/15  Manticore: {mHealth}/10");
}

//Computes value for damage, taking the current round as the parameter and returning int damage (expected)
int ComputeDamage(int round)
{
    int damage = 0;

    if (round % 3 == 0 && round % 5 == 0)
    {
        damage = 10;
        return damage;
    }

    else if (round % 3 == 0 || round % 5 == 0)
    {
        damage = 3;
        return damage;
    }

    else
    {
        damage = 1;
        return damage;
    }
    
}

//Checks whether number inputted from player 2 matches targetNumber (manticore distance), and if it does apply the passed paramter of damage
int TargetRangeToDamage (int number, int targetNumber, int damage)
{
    if(number < targetNumber)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
        return 0;
    }

    else if(number > targetNumber)
    {
        Console.WriteLine("That round OVER SHOT of the target.");
        return 0;
    }

    else if(number == targetNumber)
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        return damage;
    }

    return 0;


}