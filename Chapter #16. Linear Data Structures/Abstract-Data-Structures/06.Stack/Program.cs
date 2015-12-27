using System;
using System.Collections.Generic;

namespace _06.Stack
{
    class Program
    {
        static void Main()
        {
            Stack<string> names = new Stack<string>();
            names.Push("01. Pepa");
            names.Push("02. Bugs Bunny");
            names.Push("03. Rambo");
            names.Push("04. Miss Piggy");
            names.Push("05. Big Chicken");
            while (names.Count > 0)
            {
                string name = names.Pop();
                Console.WriteLine(name);
            }
            Console.WriteLine(names.Count);

            Stack<int> indexesStack = new Stack<int>();
            string expression = "4 * ( 12 - 7 / ( 32 * ( 18 - 2 ) ) )";
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexesStack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startIndex = indexesStack.Pop();
                    Console.WriteLine(expression.Substring(startIndex,(i - startIndex +1)));
                }
            }

        }
    }
}
