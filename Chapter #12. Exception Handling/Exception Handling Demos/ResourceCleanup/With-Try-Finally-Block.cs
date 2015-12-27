using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceCleanup
{
    class WithTryFinallyBlock
    {
        static void Main(string[] args)
        {
            // TO DO...

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
            // In this case => reader outside try-catch block will throw ApplicationException insead of FileNotFoundException !!!!
            //TextReader reader = new StreamReader(wrongFileName);
          
            // Exception could be trown in the code below
            try
            {
                TextReader reader = new StreamReader(wrongFileName);
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
            catch (FileNotFoundException fnfe)
            {
                // Inform the user that there is no such file
                Console.WriteLine("Da iba: '{0}' ni sushtestua!!", wrongFileName);
            }
            // finally will work only if reader is outside try-catch block
            //finally
            //{
                    //// Always close reader if it was opened 
            //    reader.Close();
            //}
        }







    }
}
