using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SteamReaderWithUsing
{
    class Program
    {
        static void Main()
        {

            StreamReader textPath = new StreamReader(@"C:\Program Files (x86)\Notepad++\readme.txt");
            
            // Below signature allows 2 secure properly closing of files and streams
          // using care for .Close() property
            using (textPath)
            {
                string line = textPath.ReadLine();
                while (line != null)
                {
                    Console.WriteLine("|Line| => " + line);
                    line = textPath.ReadLine();
                }
            }

        }
    }
}
