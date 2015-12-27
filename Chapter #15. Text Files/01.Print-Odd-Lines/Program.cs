using System;
using System.IO;

namespace _01.Print_Odd_Lines
{
    class Program
    {
        static void Main()
        {
            StreamReader text = new StreamReader("../../../numbers.txt");

            int counter = 1;
            using (text)
            {
                string line = text.ReadLine();
                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }

                    counter++;
                    line = text.ReadLine();
                }
            }
        }
    }
}
