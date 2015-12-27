using System;
namespace _04.StreamWriter
{
    class Program
    {
        static void Main()
        {
            System.IO.StreamWriter textWriter = new System.IO.StreamWriter("../../../numbers2.txt");

            using (textWriter)
            {
                for (int i = 0; i <= 20; i++)
                {
                    if (i % 2 == 1)
                    {
                        textWriter.WriteLine("number ==> " + i);
                    }
                    else
                    {
                        textWriter.WriteLine("Желязко ==> " + i);
                    }
                    
                }
            }
            Console.WriteLine("D@ne!");
        }
    }
}
