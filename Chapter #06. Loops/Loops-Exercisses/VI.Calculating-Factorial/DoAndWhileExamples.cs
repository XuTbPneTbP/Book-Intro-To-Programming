using System;
using System.Numerics;

class DoAndWhileExamples
{
static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        WhileLoop(n);

        Console.WriteLine("#############################");

        DoWileLoop(n);

    }

    private static void DoWileLoop(int z)
    {
        decimal factorial = 1;

        do
        {
            factorial *= z;
            z--;
        } 
        while (z > 0);

        Console.WriteLine("Factorial = {0}", factorial);
    }

    private static void WhileLoop(int z)
    {
        decimal factorialN = 1;
        int n = z;

        while (true)
        {
            if (z < 1)
            {
                break;
            }
            factorialN *= z;
            z--;
        }

        Console.WriteLine("{0}! = {1}", n, factorialN);
    }
}

