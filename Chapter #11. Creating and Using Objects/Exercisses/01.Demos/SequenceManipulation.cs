using System;

namespace _01.Demos
{
    public class SequenceManipulation
    {
        private static int currentValue = 0;
        public static void NextValue(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
