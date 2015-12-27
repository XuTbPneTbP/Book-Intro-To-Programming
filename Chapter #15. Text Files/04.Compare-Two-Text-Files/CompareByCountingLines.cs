using System;
using System.IO;

namespace _04.Compare_Two_Text_Files
{
    class CompareByCountingLines
    {
        static void Main()
        {
            string pathA = "../../../numbers.txt";
            string pathB = "../../../newFile.txt";
            int n = CountLinesInText(pathB);
            int m = CountLinesInText(pathA);

            if (n != m)
            {
                Console.WriteLine("0Ps@!!!");
                Console.WriteLine("File {0} have {1} line(s)", pathA, m);
                Console.WriteLine("File {0} have {1} line(s)", pathB, n);
            }
        }

        private static int CountLinesInText(string path2File)
        {
            StreamReader reader = new StreamReader(path2File);
            int numberOfLines = 0;

            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numberOfLines++;
                }
            }

            return numberOfLines;
        }
    }
}
