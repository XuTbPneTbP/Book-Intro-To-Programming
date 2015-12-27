using System;

class InRange
{
    static void Main()
    {
        Console.Write("Enter digit from 1 to 9 : ");
        int score = int.Parse(Console.ReadLine());
        if ((score >= 1) && (score <= 3))
        {
            Console.WriteLine(score*10);
        }
        else if ((score >= 4) && (score <= 6))
        {
            Console.WriteLine(score*100);
        }
        else if ((score >= 7) && (score <= 9))
        {
            Console.WriteLine(score * 100);
        }
        else if (score == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("Invalid SCORE!!!!");
        }
    }
}

