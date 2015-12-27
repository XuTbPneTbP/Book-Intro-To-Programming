using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadStackTrace
{
    class WithNestedExceptions
    {
       static void Main(string[] args)
        {
            // Original File
            //string wrongFileName = "../../../SomeTestData.txt";
            try 
	        {
                string wrongFileName = "../../../SomeTestDataDemo.txt";
                ReadFile(wrongFileName);
	        }
	        catch (Exception custEx)
	        {
                throw new ApplicationException("Bah maa my!", custEx);
	        }
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
