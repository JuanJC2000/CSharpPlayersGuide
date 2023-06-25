CountDown(10);
void CountDown(int number)
{
    Console.WriteLine(number);
    if (number == 1    ) return;
    CountDown(number - 1);
    
}