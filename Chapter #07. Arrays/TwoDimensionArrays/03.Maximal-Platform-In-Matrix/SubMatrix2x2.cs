﻿using System;

class SubMatrix2x2
{
    static void Main()
    {   //Declare and initialize the matrix
        int[,] matrix = 
        {
            {10,20,0,4},
            {10,3,9,8},
            {14,16,7,9}
        };
        //Find maximal sum platform of size 2x2
        long bestSum = long.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        { // We do not iterate trought entire matrix 'cuz we go out of range. Indexes begin from [0] --> so Lenght - 1
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {   // we access all four elements of sub-array with size 2x2
                long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        //Printing the result
        Console.WriteLine("The best platform is:");
        Console.WriteLine(" {0} {1}",matrix[bestRow,bestCol], matrix[bestRow,bestCol+1]);
        Console.WriteLine(" {0} {1}", matrix[bestRow+1, bestCol], matrix[bestRow+1,bestCol+1]);
        Console.WriteLine("The maximum sum is {0}",bestSum);
    }
    
}

