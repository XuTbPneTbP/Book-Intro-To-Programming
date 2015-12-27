using System;
using System.IO;
using System.Text;

namespace _03.Readin_Cyrillic_Content
{
    class WithEncodingUTF8
    {
        static void Main()
        {
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            StreamReader someText = new StreamReader("../../../intex.txt", win1251);

            //Encoding utf8 = Encoding.GetEncoding("UTF-8");
            //StreamReader someText = new StreamReader("../../../intex.txt", utf8);

            using (someText)
            {
                string currentLine = someText.ReadLine();

                while (currentLine != null)
                {
                    Console.WriteLine("=> " + currentLine);
                    currentLine = someText.ReadLine();
                }
            }
        }
    }
}
