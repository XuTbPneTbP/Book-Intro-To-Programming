using System;

namespace _09._1.Swap_Values
{
    public class Swap
    {                                                   
                                                        //a = 10, b = 5
        public static void SwapValue(int a, int b)
        {
            Console.WriteLine("a = {0} + {1} = {2}", a, b, a + b);   // a = 10 + 5 = 15
            a = a + b;

            Console.WriteLine("b = {0} - {1} = {2}", a, b, a - b);  // b = 15 - 5 = 10 => take the value of 'a'
            b = a - b;



            a = a - b;

            Console.WriteLine("a = {0} - {1} = {2}", a, b, a - b);   // a = 15 - 10 = 5 => take the value of 'b'
            
        }
    }
}
