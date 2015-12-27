using System;
using System.IO;
using System.Text;

namespace _03.Add_Line_Numbers
{
    class Program
    {
        static void Main()
        {
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            string newFile = "../../../Add-Line-Numbers.txt";
            string file2BeReaded = "../../../intex.txt";

            StreamReader reader = new StreamReader(file2BeReaded);
            StreamWriter writer = new StreamWriter(newFile);

            int lineCounter = 1;

            using (reader)
            {
                using (writer)
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine("#{0}: {1}", lineCounter, line);
                        lineCounter++;
                    }
                }
            }

            Console.WriteLine("D0N@!");

        }
    }
}
