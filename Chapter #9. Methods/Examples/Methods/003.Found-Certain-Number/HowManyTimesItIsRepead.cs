using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.Found_Certain_Number
{
    class HowManyTimesItIsRepead
    {
        static void Main()
        {
            Console.WriteLine("You have array[]{1,2,3,3,4,6,12,8,3,3,3,2,2,1,11,1,4}" +
            "--> Choose a number & I'll tell you how many times this number is repeated in the array! Suck-a!!");
            int[] array = new int[] { 1, 2, 3, 3, 4, 6, 12, 8, 3, 3, 3, 2, 2, 1, 11, 1, 4 };
            int number = int.Parse(Console.ReadLine());
            CountOccurences(array, number);
        }
        static void CountOccurences(int[] array, int number)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    counter++;
                }
            }
            Console.WriteLine("The given number {0} is found {1} times in the array", number, counter);
        }
    }
}
