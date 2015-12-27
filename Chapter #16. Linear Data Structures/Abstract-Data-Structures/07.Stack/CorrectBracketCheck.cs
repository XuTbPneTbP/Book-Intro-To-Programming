using System;
using System.Collections.Generic;

namespace _07.Stack
{
    class CorrectBracketCheck
    {
        static void Main()
        {
            string expression = "1 + (3 + 2 - (2 + 3) * 4 - ((3 + 1) * (7 - 4)))";
            Stack<int> stack = new Stack<int>();

            bool correctBrackets = true;

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (ch == '(')
                {
                    // Add element at the top of the collection
                    stack.Push(i);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    {
                        correctBrackets = false;
                        break;
                    }
                    // Removes and returns the object at the top of the stack
                    stack.Pop();
                }
            }

            // Final check is there a correct pair of brackets ()
            if (stack.Count != 0)
            {
                correctBrackets = false;
            }

            Console.WriteLine("Are the brackets correct? => " + correctBrackets);

        }
    }
}
