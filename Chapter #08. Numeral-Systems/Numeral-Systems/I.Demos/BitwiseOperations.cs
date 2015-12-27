using System;
using System.ComponentModel.Design;

namespace I.Demos
{
    class BitwiseOperations
    {
        static void Main()
        {
           
            Console.WriteLine("================================");
            //OddEvenExample();

            int e = 187;
            int f = 1;
            int mask = f << 5;

            string binaryOne = Convert.ToString(e, 2);
            string binaryTwo = Convert.ToString(mask, 2).PadLeft(8, '0');

            Console.WriteLine(binaryOne + " => " + e);
            Console.WriteLine("&");
            Console.WriteLine(  binaryTwo + " => " + mask);
            Console.WriteLine("=");
            Console.WriteLine(e & mask);
            Console.WriteLine("======================================");
            Console.WriteLine(Convert.ToString(mask, 2));
        }

        private static void OddEvenExample()
        {
            Console.WriteLine("Bitwise operation 'AND' => '&' ");
            Console.WriteLine("Check if given bit in a number is odd or even => Evens are bit value 0, odds are bit value 1");

            string even = "Even";
            string odd = "Odd";

            for (int i = 0; i < 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write("|{0, -4}|: {1} => ", even, i);
                    Console.WriteLine(Convert.ToString(i, 2).PadLeft(8, '0'));
                }
                else
                {
                    Console.Write("|{0, -4}|: {1} => ", odd, i);
                    Console.WriteLine(Convert.ToString(i, 2).PadLeft(8, '0'));
                }

            }

        }

    }
}
