//declare and then iniatilize array of ints, name 'score'. Its size is 5.
int[] scores = new int[5];

//for loop which loops through the array(score) length.
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine("Input 5 numbers"); //Asks user for input each iteration
    int arrayNumbers = Convert.ToInt32(Console.ReadLine()); // Gets the number inputted and saves it to local variable arrayNumbers
    scores[i] = arrayNumbers; //Set currennt index of scores array to the value of arrayNumbers, which is the number the user inputs
}

//declare a new array of ints, name 'replicator' 
int[] replicator = scores[0..]; //could use 5, but instead we just leave the second value empty to indicate we want the whole array
                                //Using the range operator, we can easily copy over the whole array into our new variable array replicator
                                    
                                
//For loop that will loop through replicator length, but could be either of the arrays or just a size of 5.
for(int i = 0;i < replicator.Length; i++)
{
    Console.WriteLine("Real value: " + scores[i]); //Print current iteration of index of array
    Console.WriteLine("Replicator value: " + replicator[i]);
    
}

   