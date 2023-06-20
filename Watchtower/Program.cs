Console.Write("Input an x and y value");
int xValue = Convert.ToInt32(Console.ReadLine());
int yValue = Convert.ToInt32(Console.ReadLine());



if (xValue == 0 && yValue == 0)
    Console.WriteLine("The enemy is here!");

else if (xValue > 0)
    if (yValue > 0)
        Console.WriteLine("The enemy is to the northeast!");
    else if (yValue == 0)
        Console.WriteLine("The enemy is to the east!");
    else Console.WriteLine("The enemy is to the southeast!");

else if (xValue < 0)
    if (yValue > 0)
        Console.WriteLine("The enemy is to the northwest!");
    else if (yValue == 0)
        Console.WriteLine("The enemy is to the west!");
    else Console.WriteLine("The enemy is to the southwest!");

else if (xValue == 0)
    if (yValue > 0)
        Console.WriteLine("The enemy is to the north!");
    else if (yValue < 0)
        Console.WriteLine("The enemy is to the south!");

