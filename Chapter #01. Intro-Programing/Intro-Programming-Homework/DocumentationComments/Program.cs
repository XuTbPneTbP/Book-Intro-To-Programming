using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationComments
{
    class Program
    {
        static void Main(string[] args)
        {
            string ya = "It's not your bussines!";
            SayHello(ya);

            HelloPeshko pesho = new HelloPeshko();
          Console.WriteLine(pesho);
        }

        /// <summary>
        /// Just show how to comment methods
        /// </summary>
        /// <param name="ya"></param>
        private static void SayHello(string ya)
        {
            Console.WriteLine("Hello & Goodbye! " + ya);
        }
    }

    /// <summary>
    /// Peshko can say Hi!
    /// </summary>
    public class HelloPeshko
    {
        public override string ToString()
        {
            return "hELLO бАЧА!";
        }
    }
    
}
