using System;
using System.Collections.Generic;
using System.IO;

namespace _02._1DirectoryTraverserBFS
{
    public class TraverseBFS
    {
        public static void TraverseDir(string directoryPath)
        {
            Queue<DirectoryInfo> visitedDirsQueue = new Queue<DirectoryInfo>();
            visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));
            while (visitedDirsQueue.Count > 0)
            {
                DirectoryInfo currentDir = visitedDirsQueue.Dequeue();
                Console.WriteLine(currentDir.FullName);

                DirectoryInfo[] childrens = currentDir.GetDirectories();
                foreach (var children in childrens)
                {
                    visitedDirsQueue.Enqueue(children);
                }
            }
        }

        static void Main()
        {
            TraverseDir(@"C:\Users\Luben\Documents");
        }
    }
}
