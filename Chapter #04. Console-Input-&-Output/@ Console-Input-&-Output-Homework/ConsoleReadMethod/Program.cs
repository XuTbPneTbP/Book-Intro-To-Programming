using System;

namespace ConsoleReadMethod
{
    class Program
    {
        static void Main()
        {
            int codeRead = 0;

            do
            {
                codeRead = Console.Read();
                if (codeRead != 0)
                {
                    Console.Write((char)(codeRead));
                }
            } while (codeRead == 10); // 10 is ENTER
        }
    }
}
