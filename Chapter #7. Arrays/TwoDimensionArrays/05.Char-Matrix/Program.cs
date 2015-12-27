using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 26; //rows
            int width = 26; //columns
            string[,] matrix = new string[height, width];

            for (int row = 0; row < height; row++)
            {
                for (int columns = 0; columns < width; columns++)
                {
                    matrix[row,columns] = " " + (char)('a' + row) + (char)('a' + columns) ;
                    Console.Write(matrix[row,columns]);
                }
                Console.WriteLine();
            }
        }
    }
}
