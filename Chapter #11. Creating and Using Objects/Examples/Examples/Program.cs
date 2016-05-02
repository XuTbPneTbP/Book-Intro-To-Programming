using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Benny", "Blue");
           //cat.Alabala = "green";
            Console.WriteLine(cat.Alabala);
        }
    }

    public class Cat
    {
        private string name;
        private string color;

        public Cat(string a, string b)
        {
            this.name = a;
            this.color = b;
        }

        public string Alabala
        {
            get
            {
                return this.color;
            }
            private set
            {
            }
        }

        //public override string ToString()
        //{
        //    return this.name.ToString();
        //}
    }
}
