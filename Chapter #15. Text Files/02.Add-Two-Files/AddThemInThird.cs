using System;
using System.IO;
using System.Text;

namespace _02.Add_Two_Files
{
    class AddThemInThird
    {
        const string PATH1 = "../../../numbers.txt";
        const string PATH2 = "./../intex.txt";
        const string OutputFile = "../../newFile.txt";
        static void Main()
        {
            try
            {
                Write2NewFile(PATH1, OutputFile);
                Write2NewFile(PATH2, OutputFile);
                Console.WriteLine("D@ne!");

            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("File no found!");
            }
            catch (IOException exception)
            {
                Console.WriteLine("Error: {0}.", exception);
            }

        }

        private static void Write2NewFile(string path, string outputFile)
        {
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            StreamReader text = new StreamReader(path, win1251);
            StreamWriter newPath = new StreamWriter(outputFile, true);

            using (text)
            {
                using (newPath)
                {
                    string line = text.ReadLine();
                    while (line != null)
                    {
                        newPath.WriteLine(line);
                        line = text.ReadLine();
                    }

                }
            }

        }

    }
}
