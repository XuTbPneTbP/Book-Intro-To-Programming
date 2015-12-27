using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.Print_Name
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter some name: ");
            string name = Console.ReadLine();
            SayName(name);
        }
        static void SayName(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
    }
}
