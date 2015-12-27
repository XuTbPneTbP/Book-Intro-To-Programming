using System;
using System.Collections.Generic;
using System.Linq;

namespace Demos
{
    class Program
    {
      
        static void Main()
        {
            string str =
                "Be sure, too, that?? you're settled up on your Windows Update!!! requests, as there may be relevant system patches that need installing before .NET will fit comfortably on your system.";
            int wordCount = str.WordCount();
           // Console.WriteLine("Words counted: {0}", wordCount);

            List<int> numbersDemo = new List<int> {1, 12, -8, 0, 69, 834};
            Console.WriteLine(numbersDemo.ToString<int>());
            numbersDemo.IncreaseWith(-10);
            Console.WriteLine(numbersDemo.ToString<int>());
        }
    }
}
