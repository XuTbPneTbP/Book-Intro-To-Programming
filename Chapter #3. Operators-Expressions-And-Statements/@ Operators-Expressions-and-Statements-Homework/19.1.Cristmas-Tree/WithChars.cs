using System;

class WithChars
{
    static void Main()
    {
        Console.WriteLine(" do you want to see christam tree?");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            
            int asterisksCount = i;
            string asterisks = new string('*', asterisksCount);
            int spacesCount = n - asterisksCount;
            string spaces = new string(' ', spacesCount);
            Console.Write(spaces);
            Console.Write(asterisks);
            Console.Write(" | ");
            Console.Write(asterisks);
            Console.WriteLine(spaces);
        }

    }
}

