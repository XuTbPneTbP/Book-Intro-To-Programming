using System;

namespace _12.BitShifting
{
    class Program
    {
        static void Main()
        {
            ushort a = 5;
            ushort b = 12;
            Console.WriteLine("number a = {0}", a);
            Console.WriteLine("number ~a = {0}", ~a);
            Console.WriteLine("number b = {0}", b);
            Console.WriteLine(Convert.ToString(~a, 2).PadLeft(16, '0') + "  <-- ~a");
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(16, '0') + "  <-- a");
            Console.WriteLine(Convert.ToString(b, 2).PadLeft(16, '0') + "  <-- b");

            Console.WriteLine();
            Console.WriteLine(Convert.ToString(a | b, 2).PadLeft(16, '0') + " <-- a|b" + " The new number is c = {0}", a | b);
            Console.WriteLine(Convert.ToString(a & b, 2).PadLeft(16, '0') + " <-- a&b  The new number is c = {0}", a & b);
            Console.WriteLine(Convert.ToString(a ^ b, 2).PadLeft(16, '0') + " <-- a^b  The new number is c = {0}", a ^ b);
            Console.WriteLine(Convert.ToString(~a & b, 2).PadLeft(16, '0') + " <-- ~a&b  The new number is {0}", ~a & b);
            Console.WriteLine(Convert.ToString(a << 1, 2).PadLeft(16, '0') + " <-- a<<1 bitshifting with one from right to left  The new number is c = {0}", a << 1);
            Console.WriteLine(Convert.ToString(a << 3, 2).PadLeft(16, '0') + " <-- a<<3 bitshifting with three from right to left  The new number is c = {0}", a << 3);
            Console.WriteLine(Convert.ToString(a << 2, 2).PadLeft(16, '0') + " <-- a<<2 bitshifting with one from right to left  The new number is c = {0}", a << 2);
            Console.WriteLine(Convert.ToString(a << 4, 2).PadLeft(16, '0') + " <-- a<<4 bitshifting with one from right to left  The new number is c = {0}", a << 4);
            Console.WriteLine(Convert.ToString(a >> 1, 2).PadLeft(16, '0') + " <-- a>>1 bitshifting with one from right to left  The new number is c = {0}", a >> 1);
            Console.WriteLine(Convert.ToString(a >> 5, 2).PadLeft(16, '0') + " <-- a>>5 bitshifting with one from right to left  The new number is c = {0}", a >> 5);
            Console.WriteLine();
        }
    }
}
