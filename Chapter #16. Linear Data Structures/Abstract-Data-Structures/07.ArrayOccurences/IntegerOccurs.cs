using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ArrayOccurences
{
    class IntegerOccurs
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] numbers = new int[1000];

            Console.WriteLine("=====================================================");
            Console.WriteLine("Random from 0 to 1 000 = >");
            Console.WriteLine("=====================================================");
            for (int i = 0; i < numbers.Length; i++)
            {
                int random = rnd.Next(0, 100);
                numbers[i] = random;
                Console.Write("|" + numbers[i] + "|" + " ");
            }
            Console.WriteLine();

            CalculateOccurences(numbers);
        }

        static void CalculateOccurences(int[] someNumbers)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("Enter 3 random numbers from 0 to 1 000");
            Console.WriteLine("=====================================================");

            IDictionary<int, int> occurs = new SortedDictionary<int, int>();
            int counter = 1;

            while (true)
            {
                if (counter >= 4)
                {
                    break;
                }
                Console.Write("Number {0} = > ", counter);
                string line = Console.ReadLine();

                try
                {
                    int number = int.Parse(line);
                    int occurences = 1;
                    for (int i = 0; i < someNumbers.Length; i++)
                    {
                        if (number == someNumbers[i])
                        {
                            occurences++;
                            continue;
                        }
                        occurs[number] = occurences;
                    }
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry dude! I need a number! Suck@!");
                }

            }

            foreach (var number in occurs)
            {
                Console.WriteLine("Number |{0}| occures : {1} times", number.Key, number.Value);
            }

        }
    }
}
