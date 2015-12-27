using System;

class WithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers: ");
        string[] alaBala = Console.ReadLine().Split();
        double first = Convert.ToDouble(alaBala[0]);
        double second = Convert.ToDouble(alaBala[1]);
        double third = Convert.ToDouble(alaBala[2]);
        if (first * second * third > 0)
        {
            Console.WriteLine("+");
        }
        else if (first * second * third < 0)
        {
            Console.WriteLine("-");
        }
        else if (first * second * third == 0)
        {
            Console.WriteLine("0");
        }
    }
}

