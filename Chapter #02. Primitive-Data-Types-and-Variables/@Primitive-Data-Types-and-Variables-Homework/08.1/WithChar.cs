using System;
using System.Text;

class WithChar
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyRight = '\u00a9';
        // Console.WriteLine(copyRight);
        for (int row = 1; row < 10; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write(copyRight);
            }

            Console.WriteLine();
        }
    }
}

