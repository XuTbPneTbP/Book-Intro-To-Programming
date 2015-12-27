using System;

class WithRandomGenerator
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int loops = 10;
        Random nums = new Random();
        while (loops > 0)
        {
            Console.WriteLine(nums.Next(0, num));
            loops--;
        }
    }
}

