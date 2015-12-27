using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class WrongTextFile
    {
        static void Main(string[] args)
        {
            // Original File
            //string wrongFileName = "../../../SomeTestData.txt";
            string wrongFileName = "../../../SomeTestDataDemo.txt";
            ReadFile(wrongFileName);
        }

        private static void ReadFile(string wrongFileName)
        {
            TextReader reader = new StreamReader(wrongFileName);
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();
        }
    }
}
