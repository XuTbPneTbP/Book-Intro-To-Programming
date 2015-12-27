using System;
using System.Text;

class WithSymbol
{
    static void Main()
    {
  //     char copyright = '\u00A9';
        Console.OutputEncoding = Encoding.UTF8;
//        Console.Write(@"
//               {0}
//              {0} {0}
//             {0}   {0}
//            {0} {0} {0} {0}", copyright);
//        Console.WriteLine();


        int n = 10;//int.Parse(Console.ReadLine());

        //Console.WriteLine(new  string('Ю', 50));


        for (int i = 0; i < n; i++)
        {
            int copyrightCount = i;
            string copy = new string('\u00a9', copyrightCount);
            int spacesCount = n - copyrightCount;
            string spaces = new string(' ', spacesCount);
            Console.Write(spaces);
            Console.Write(copy);
            Console.Write('\u00a9');
            Console.Write(copy);
            Console.WriteLine(spaces);
        }    
    }
}

