using System;
using System.Text;
class Somesht
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char smileyChar = '☺';
        int smileyInt = smileyChar;  // == 9786;

        Console.WriteLine(smileyChar);
        Console.WriteLine(smileyInt);

        Console.WriteLine(Convert.ToString(smileyChar, 2));
        Console.WriteLine(Convert.ToString(smileyInt, 2));

        Console.WriteLine(Convert.ToString(-smileyChar, 2));
        Console.WriteLine(Convert.ToString(-smileyInt, 2));

        Console.WriteLine("##############################");

        int keyboardChar = Console.Read();
        Console.WriteLine(keyboardChar);

        #region "basic"

        //int a = 12;
        //int b = 5;
        //int c = 1;
        //double d = 4.0;

        ////int a = int.Parse(Console.ReadLine());
        ////int b = int.Parse(Console.ReadLine());
        ////int c = int.Parse(Console.ReadLine());
        ////double d = double.Parse(Console.ReadLine());

        //double result = (a + b + c + d) / 4;
        //Console.WriteLine(result);

        Console.WriteLine("##############################");
        #endregion "basic"

        #region "advanced"

        //string input = Console.ReadLine();

        #endregion "advanced"
    }
}
