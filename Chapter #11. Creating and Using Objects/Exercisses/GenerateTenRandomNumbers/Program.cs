using System;

namespace GenerateTenRandomNumbers
{
    class Program
    {
        static void Main()
        {
            Random number = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int first = 100;
                int last = 201;
                int random = number.Next(first, last);
                Console.WriteLine(i + " => " +random);
            }
        }
    }
}
