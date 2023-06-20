int theNumber = Convert.ToInt32(Console.ReadLine());
bool isEven = theNumber % 2 == 0;

if (isEven)
    Console.WriteLine("Tick");
else
    Console.WriteLine("Tock");