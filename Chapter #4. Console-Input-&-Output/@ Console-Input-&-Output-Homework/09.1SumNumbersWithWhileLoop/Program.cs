using System;
using System.Runtime.CompilerServices;

namespace _09._1.SumNumbersWithWhileLoop
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int sum = 0;

            while (command != "end")
            {
              
                try
                {
                    int number = int.Parse(command);

                    sum += number;

                    Console.WriteLine("Current sum => {0}", sum);

                    Console.Write("Enter number: ");
                }
                catch (Exception)
                {

                    Console.WriteLine( "I said NUMBERS BITCH@!!!!" );
                    
                }

                command = Console.ReadLine();

            } // End of loop bracket

        }
    }
}
