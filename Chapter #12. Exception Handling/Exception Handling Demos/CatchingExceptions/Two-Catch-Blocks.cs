using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingExceptions
{
    class TwoCatchBlocks
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
                
                reader.Close();
        
            }
            catch (FileNotFoundException fnfe)
            {
                // Inform the user that there is no such file
                Console.WriteLine("Da iba: '{0}' ni sushtestua!!", wrongFileName);
            }
            catch(IOException ioe)
            {
                // Just print the stack trace
                //Console.WriteLine("Ut tuka ti gyrmi e pidal!!!");
                Console.WriteLine(ioe.StackTrace);
            }
        }
    }
}
