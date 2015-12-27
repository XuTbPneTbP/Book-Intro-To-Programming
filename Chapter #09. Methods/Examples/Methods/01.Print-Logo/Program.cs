using System;

    class Program
    {
        static void Main()
        {           
            JohnJayLogo();
        }
        static void PrintLogo()
        {
            Console.WriteLine("Microsoft");
            Console.WriteLine("www.microsoft.com");
        }
        static void JohnJayLogo()
        {
            System.Console.WriteLine("John Jay Rambo '\u00a9'");
            PrintLogo();
        }
    }

