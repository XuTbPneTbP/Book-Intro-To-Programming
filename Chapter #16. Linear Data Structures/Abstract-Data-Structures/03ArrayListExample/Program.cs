using System;
using System.Collections;

namespace _03ArrayListExample
{
    class Program : Examples
    {
        static void Main()
        {
            // Array list is untyped, so it can keep all kind of elements - int, string, DateTime and other objects
            ElementsFromDifferentTypes();
            Console.WriteLine("*********************************************");
            ArrayListOfNumbers();
        }
    }
}
