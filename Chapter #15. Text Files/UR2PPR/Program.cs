using System;

// Universal Relative to Physical Part Resolver
namespace UR2PPR
{
    class Program: UniversalFilePathResolver
    {
        static void Main()
        {
            // http://www.nakov.com/blog/2009/07/14/universal-relative-to-physical-path-resolver-for-console-wpf-and-aspnet-apps/

            //C:\Program Files (x86)\Notepad++\readme.txt
            string textPath = CatchThePath(@"~\intex.txt");

            Console.WriteLine(textPath);
        }
    }
}
