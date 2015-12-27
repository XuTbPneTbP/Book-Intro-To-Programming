using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Hexadecimal_To_Decimal
{
    class Program
    {
        static void Main()
        {
            string hexa = Convert.ToString(Console.ReadLine());
            int number = Int32.Parse(hexa, System.Globalization.NumberStyles.HexNumber);            
            Console.WriteLine(number);         
        }
    }
}
