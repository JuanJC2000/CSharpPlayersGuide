//declare and initalize array 
int[] array = new int[] { 4, 51, -7, 12, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue; //Start higher than anything in the array possible (good coding practice!)
int total = 0;

//for each, declare new variable name 'value' to hold the current item in the array
foreach (int value in array)
{
    //If the current item in value is smaller than currentSmallest
    if (value < currentSmallest)
    {
        currentSmallest = value; //CurrentSmallest copies the current value of the item
    }
    
        
}
Console.WriteLine(currentSmallest); //Show the number

//Same thing here, foreach item inside the array, hold the item inside value.
foreach(int value in array)
{
    total += value; //Add that current item value to total
}

//Set a new variable float average, and cast our total divided by the number of items in the array
float average = (float)total/array.Length;
Console.WriteLine(average); 