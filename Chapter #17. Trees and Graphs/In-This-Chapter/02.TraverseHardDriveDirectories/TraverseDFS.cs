using System;
using System.IO;

namespace _02.TraverseHardDriveDirectories
{
    class DirectoryTraverserDfS
    {
        static void TraverseDir(DirectoryInfo dir, string spaces)
        {
            Console.WriteLine(spaces + dir.FullName);
            DirectoryInfo[] childrens = dir.GetDirectories();
            foreach (var children in childrens)
            {
                TraverseDir(children, spaces + "    ");
            }
        }
        static void TraverseDir(string directoryPath)
        {
            TraverseDir(new DirectoryInfo(directoryPath), String.Empty);
        }
        static void Main()
        {
            TraverseDir(@"C:\Users\Luben\Documents\SQL Server Management Studio");
        }
    }
}
