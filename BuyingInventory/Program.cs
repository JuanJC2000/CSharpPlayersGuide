
Console.WriteLine("The following items are available:");
string firstItem = "Rope";
string secondItem = "Torches";
string thirdItem = "Climbing Equipment";
string fourthItem = "Clean Water";
string fifthItem = "Machete";
string sixthItem = "Canoe";
string seventhItem = "Food Suppplies";

double priceFirst = 10;
double priceSecond = 15;
double priceThird = 25;
double priceFourth = 1;
double priceFifth = 20;
double priceSixth = 200;
double priceSeventh = 1;


Console.WriteLine($"1 - {firstItem, -20}");
Console.WriteLine($"2 - {secondItem,-20}");
Console.WriteLine($"3 - {thirdItem,-20}");
Console.WriteLine($"4 - {fourthItem,-20}");
Console.WriteLine($"5 - {fifthItem,-20}");
Console.WriteLine($"6 - {sixthItem,-20}");
Console.WriteLine($"7 - {seventhItem,-20}");
Console.Write("What number do you want to see the price of? ");
double buyNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("What is your name, Traveller? ");
string travellerName = Console.ReadLine();
if (travellerName == "Juan")
{
    priceFirst = priceFirst / 2;
    priceSecond = priceSecond / 2;
    priceThird = priceThird / 2;
    priceFourth = priceFourth / 2;
    priceFifth = priceFifth / 2;
    priceSixth = priceSixth / 2;
    priceSeventh = priceSeventh / 2;
}

//Not the best solution, a better solution is to make a switch that can compare itemNumber with a string. SAve that as a string variable item. Then, make a new switch that compares the string against its price, saving the value as a new variable int price.
//This allows for easy refactoring, as instead of adding a new variable for each value we can just take the value of price and divide by 2.
string response = buyNumber switch
{
    1 => $"{firstItem} cost(s) {priceFirst} gold.",
    2 => $"{secondItem} cost(s) {priceSecond} gold.",
    3 => $"{thirdItem} cost(s) {priceThird} gold.",
    4 => $"{fourthItem} cost(s) {priceFourth} gold.",
    5 => $"{fifthItem} cost(s) {priceFifth} gold.",
    6 => $"{sixthItem} cost(s) {priceSixth} gold.",
    7 => $"{seventhItem} cost(s) {priceSeventh} gold.",
    _ => "What the hell is this."
};

Console.WriteLine(response);

