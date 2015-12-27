using System;

class RecursiveVersion
{
    static int numberOfLoops;
    static int numberOfIterations;
    static int[] loops;

    static void Main()
    {
        Console.Write("How much loops do you want: ");
        numberOfLoops = int.Parse(Console.ReadLine());
        Console.Write("How much iterations do you want: ");
        numberOfIterations = int.Parse(Console.ReadLine());

        loops = new int[numberOfLoops];
        NestedLoops(0);
    }
    static void PrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
    static void NestedLoops(int currentLoop)
    {
        if (currentLoop == numberOfLoops)
        {
            PrintLoops();
            return;
        }
        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1);
        }
    }
}

