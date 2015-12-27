using System;

    class ThreeDimensions
    {
        static void Main()
        {
            int dim1 = int.Parse(Console.ReadLine());
            int dim2 = int.Parse(Console.ReadLine());
            int dim3 = int.Parse(Console.ReadLine());
            int[, ,] cube = new int[dim1, dim2, dim3];

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        Console.Write("cube[{0},{1},{2}] = ",i,j,k);
                        cube[i, j, k] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
            }

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    for (int k = 0; k < cube.GetLength(2); k++)
                    {
                        Console.Write(" " + cube[i,j,k]);  
                    }
                    Console.WriteLine();
                }
            }
        }
    }

