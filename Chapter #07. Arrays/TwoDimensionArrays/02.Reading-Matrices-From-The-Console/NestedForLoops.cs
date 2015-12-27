using System;

class NestedForLoops
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        //Declaration and initalization of multidimension array
        int[,] matrix = new int[rows, columns];

        Console.WriteLine("Enter the cells of the matrix:");
        // We assign values to each element
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Console.Write("matrix[{0},{1}] = ",row,col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
            //Now we print the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }


