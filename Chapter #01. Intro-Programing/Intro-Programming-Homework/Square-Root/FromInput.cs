using System;

namespace Square_Root
{
    class FromInput
    {
        static void Main()
        {
            int square = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(square) + "is this!");
        }
    }
}

