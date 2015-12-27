using System;
using System.Collections.Generic;
namespace _08.Queue
{
    class Program
    {
        static void Main()
        {
            //Example1();

            // Sequence N, N+1, 2*N
            // S = N, N+1, 2*N, N+2, 2*(N+1), 2*N + 1, 4*N, ...
            int n = 3;
            int p = 16;
            int index = 0;

            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(n);
            //Console.Write("S =");

            while (numbers.Count > 0)
            {
                index++;
                int currentNumber = numbers.Dequeue();
                Console.WriteLine("Current number:  " + currentNumber);
                if (currentNumber == p)
                {
                    Console.WriteLine();
                    Console.WriteLine("Index = " + index);
                    return;
                }
                int plus = currentNumber + 1;
                int multiply = currentNumber*2;
                Console.WriteLine("N + 1 = " + plus);
                Console.WriteLine("2 * N = " + multiply);
                numbers.Enqueue(plus);
                numbers.Enqueue(multiply);
               
            }

        }

        private static void Example1()
        {
            Queue<string> names = new Queue<string>();

            names.Enqueue("Name: Boby");
            names.Enqueue("Name: Elza");
            names.Enqueue("Name: Tom");
            names.Enqueue("Name: Franky");

            while (names.Count > 0)
            {
                string name = names.Dequeue();
                Console.WriteLine(name);
            }
        }

    }
}
