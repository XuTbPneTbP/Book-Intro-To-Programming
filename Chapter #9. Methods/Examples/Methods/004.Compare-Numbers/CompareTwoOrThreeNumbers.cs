using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004.Compare_Numbers
{
    class CompareTwoOrThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            GetMax(a, b);
            Console.WriteLine("Now enter three numbers to be compared ");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            GetTripleMax(c, d, e);
        }
        static void GetMax(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Bigger is {0}", a);
            }
            else
            {
                Console.WriteLine("Bigger is {0}", b);
            }
        }
        static void GetTripleMax(int a, int b, int c)
        {
            if ((a > b) && (a > c))
            {
                Console.WriteLine("Bigger is {0}", a);
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("Bigger is {0}", b);
            }
            else
            {
                Console.WriteLine("Bigger is {0}", c);
            }
        }
    }
}
