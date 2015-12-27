using System;

class WithNestedForLoops
{
    static void Main()
    {
        Console.Write("Enter triangle hight: ");

        int triangleHight = int.Parse(Console.ReadLine());

        for (int row = 1; row <= triangleHight; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }

    }
}

