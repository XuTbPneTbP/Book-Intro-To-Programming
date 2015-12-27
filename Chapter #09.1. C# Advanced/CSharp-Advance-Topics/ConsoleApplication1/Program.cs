using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random числа = new Random();
            int random = числа.Next();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(числа.Next(1, 200));
            }
        }
    }
}
