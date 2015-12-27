using System;

namespace _01.String_And_Char_Arrays
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("0 1 2 3 4 5 6 7 8 9 10");
            SimpleExample();
            ForLoopIndexesAndQuotes();
        }

        private static void ForLoopIndexesAndQuotes()
        {
            // With quote - кавички
            string message = "Book's title is \"Hello, C#!\"";
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("The message is {{ {0} }}", message);
            Console.WriteLine("Message length = {0} symbols", message.Length);
            Console.WriteLine("-----------------------------------------------------");
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine("message[{0}] = {1}", i, message[i]);
            }
        }
        private static void SimpleExample()
        {
            string message = "Book's title is Hello, C#!";
            char[] messageToCharArray = message.ToCharArray();
            Console.WriteLine("-----------------------------------------------------");
            char ch = messageToCharArray[8];
            Console.WriteLine(string.Join(" ", messageToCharArray));
            Console.WriteLine("Char at index 8 => " + ch);
            Console.WriteLine(messageToCharArray.Length);
            Console.WriteLine("-----------------------------------------------------");
            messageToCharArray[8] = '&';
            Console.WriteLine(string.Join(" ", messageToCharArray));
            ch = messageToCharArray[8];
            Console.WriteLine("Char at index 8 => " + ch);
            Console.WriteLine(messageToCharArray.Length);
            Console.WriteLine("-----------------------------------------------------");

            //message[8] = "SHT";
        }

    }
}
