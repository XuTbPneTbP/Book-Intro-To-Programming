using System;

class CompareNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers: ");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        if (first == second)
        {
            Console.WriteLine("Thist two numbers {0} and {1} are equal", first, second);
        }
        else
        {
            if (first > second)
            {
                Console.WriteLine(" {0} > {1}", first, second);
            }
            else
            {
                Console.WriteLine(" {0} < {1}",first,second);
            }
        }
    }
}

