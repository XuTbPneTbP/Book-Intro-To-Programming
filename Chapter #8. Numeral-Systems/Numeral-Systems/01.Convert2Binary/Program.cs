using System;

namespace _01.Convert2Binary
{
    class Program
    {
        static void Main()
        {
            int a = 151;
            int b = 35;
            int c = 43;
            int d = 251;
            int e = 1023;
            int f = 1024;

            string oneByteRepresentation = Convert.ToString(a, 2);
            string twoByteRepresentation = Convert.ToString(a, 2).PadLeft(16, '0');

            Console.WriteLine("One byte representation =>  |{0, 16}| wich means 8 bits", oneByteRepresentation);
            Console.WriteLine("Two bytes representation => |{0, 16}| wich means 16 bits", twoByteRepresentation);
        }
    }
}
