//Declare multi dimensional array with [,], with index size 4,4.
int[,] matrix = new int[4, 4];

//GetLength acceps the index of dimension you are trying to represent
// This is our outer loop, which starts at the first row (index 0)
for (int row = 0; row < matrix.GetLength(0); row++)
{
    // Now, we are on a specific row, let's go through each 'column' in this row
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        // Here, we are at a specific cell in the matrix. 
        // We access this cell using matrix[row, column] 
        // We print the value in this cell, followed by a space " "
        Console.Write(matrix[row, column] + " ");
    }
    
    Console.WriteLine();
}