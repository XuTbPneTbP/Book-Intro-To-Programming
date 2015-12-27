using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SomeFundamentals
{
    class Program
    {
        int age = 2;
        static void Main(string[] args)
        {
            DogObj johnJay = new DogObj();
            Console.WriteLine("the dog age is: " + johnJay.age);
        }
    }
}
