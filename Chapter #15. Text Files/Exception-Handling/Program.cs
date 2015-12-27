using System;
using System.IO;
using System.Text;

namespace Exception_Handling
{
    class Program
    {
        static void Main()
        {
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");

            string magicFileName = "";
            string fileName = @"../../../intex.txt";
            string fileName2 = @"../../../numbers.txt";

            magicFileName = fileName;

            try
            {
                StreamReader textFile = new StreamReader(magicFileName, win1251);
                //StreamReader textFile = new StreamReader(fileName2);
                Console.WriteLine("File {0} successfully opened!", magicFileName);
                Console.WriteLine("File content:");

                using (textFile)
                {
                    string line = textFile.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine("=> " + line);
                        line = textFile.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("File is missing => {0}", magicFileName);
            }
            catch(DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path!");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can't open file {0}", magicFileName);
            }
        }
    }
}
