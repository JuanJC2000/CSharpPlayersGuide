//Declare a tuple named 'soup' of types FoodType, MainIngredint, and Seasoning. The names are optional.
//Initalize it with the return value from the GetSoup() function.
(FoodType food, MainIngredient ingredient, Seasoning seasoning) soup = GetSoup();

//Print out the value of each tuple item.
Console.WriteLine($"{soup.food} {soup.ingredient} {soup.seasoning}"); 

//Function GetSoup: This is the top level function.
//It runs three individual functions that return the desired value of each enum.
//It then packs those returned values into a typle and returns that tuple.

(FoodType, MainIngredient, Seasoning) GetSoup()
{
    FoodType type = GetFoodType(); //Saves the returned value from GetFoodType() to a local variable 'type' of type FoodType.
    MainIngredient ingredient = GetMainIngredient(); // Exact same logic as above, same for below.
    Seasoning seasoning = GetSeasonsing();
    return(type, ingredient, seasoning); //Returns the value of type FoodType, MainIngredient, Seasoning as declared by the return type.
}


///<summary>
/// Function GetFoodType: this function prompts the user to input a food type.
/// It uses the switch expression to map the user's input string to the corresponding FoodType enum value.
///</summary>
FoodType GetFoodType()
{
    Console.Write("soup, stew, gumbo: ");
    string input = Console.ReadLine();
    return input switch
    {
        "soup" => FoodType.Soup,
        "stew" => FoodType.Stew,
        "gumbo" => FoodType.Gumbo
        
    };
}

// Function GetMainIngredient: similar to GetFoodType, but for the main ingredient of the soup.
MainIngredient GetMainIngredient()
{
    Console.Write("mushrooms, chicken, carrots, potatoes: ");
    string input = Console.ReadLine();
    return input switch
    {
        "mushrooms" => MainIngredient.Mushrooms,
        "chicken" => MainIngredient.Chicken,
        "carrots" => MainIngredient.Carrots,
        "potatoes" => MainIngredient.Potatoes

    };
}

// Function GetSeasoning: similar to GetFoodType, but for the seasoning of the soup.
Seasoning GetSeasonsing()
{
    Console.Write("spicy, salty, sweet: ");
    string input = Console.ReadLine();
    return input switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet

    };
}


// Enum definitions: these are custom types we've defined.
// They enumerate the possible food types, main ingredients, and seasonings that can be used in the soup.
enum FoodType
{
    Soup,
    Stew,
    Gumbo
}

enum MainIngredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}