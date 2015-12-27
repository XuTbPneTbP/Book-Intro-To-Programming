using System;

class WithForLoop
{
    static void Main()
    {
       
        for (int i = 0; i <= 31; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
            else
            {
                Console.Write(-i + " ");
            }        
        }
        Console.WriteLine("Айди, айди!!:)");
    }
}

