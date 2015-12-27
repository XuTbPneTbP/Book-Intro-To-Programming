using System;

class NestedForLoop
{
    static void Main()
    {
        //Declare and initialize the matrix of size 2 (rows) x 4 (columns)
        int[,] matrix =
        {
            {1,3,5,7}, // row 0 values
            {2,4,6,8}, // row 1 values 
        };
        // Print the matrix on the console
        for (int row = 0; row < matrix.GetLength(0); row++) //GetLenght(0) for  rows
        {
            for (int col = 0; col < matrix.GetLength(1); col++) // GetLenght(1) for columns
            {
                Console.Write(matrix[row,col] + " ");
            }
            Console.WriteLine();
        }
    }
}

