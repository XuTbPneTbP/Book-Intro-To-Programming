using System;

class WithInput
{
    static void Main()
    {
        Console.WriteLine("n < 20");

        int n = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int row = 1; row <= n; row++)
        {
            counter = row;
            for (int col=0; col < n; col++)
            {
                Console.Write("|{0,3}|",counter++);                            
            }
            Console.WriteLine();
        }
    }
}

