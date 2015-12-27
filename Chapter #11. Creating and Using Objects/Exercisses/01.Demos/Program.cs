using System;

namespace _01.Demos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Sequence:");
            Console.Write("From: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("To: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Sequence[{0}...{1}]", start, end);
           SequenceManipulation.NextValue(start, end);
        }
    }
}
