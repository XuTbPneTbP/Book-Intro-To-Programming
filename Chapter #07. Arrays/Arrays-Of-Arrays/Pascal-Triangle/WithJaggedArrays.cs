using System;

class WithJaggedArrays
{
    static void Main()
    {
        int height = 5;

        //Alocate the array in a triangle form...Just draw it!!
        long[][] triangle = new long[height+1][];
        for (int row = 0; row < height; row++)
        {
            triangle[row] = new long[row + 1];
        }

        //Calculate Pascal's triangle
        triangle[0][0] = 1;
        for (int row = 0; row < height - 1; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                triangle[row + 1][col] += triangle[row][col];
                triangle[row + 1][col +1] += triangle[row][col];
            }
        }

        //Print the Pascals's triangle
        for (int row = 0; row < height; row++)
        {
            Console.Write("".PadLeft((height-row)*2));
            for (int col = 0; col <= row; col++)
            {
                Console.Write("{0,3} ",triangle[row][col]);
            }
            Console.WriteLine();
        }       
    }
}

