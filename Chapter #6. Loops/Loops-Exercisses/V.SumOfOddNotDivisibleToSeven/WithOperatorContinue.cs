using System;

class WithOperatorContinue
{
    static void Main()
    {
        Console.Write("Enter range: ");
        int range = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i <= range; i += 2)
        {
            if (i % 7 == 0) 
            {
                // Operator continue sends U back to the variable updater => that's mean it skip the rest of the loop body
                continue;
            }
            Console.WriteLine(i);
            sum += i;            
        }
        Console.WriteLine("sum = " + sum);
    }
}

