using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _05.Read_Square_Matrix
{
    class MaximalSubMatrixSum
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string sizeOfMatrix = File.ReadLines("../../../matrix.txt").ElementAt(1);
            Console.WriteLine("File.ReadLines(" + "../../../matrix.txt" + ").ElementAt(1)");
            PrintMatrix();
            Console.WriteLine("=======================================================");
            //CheckForIncorrectData(sizeOfMatrix);
            CreateMatrix(sizeOfMatrix);
        }

        private static void CreateMatrix(string sizeOfMatrix)
        {
            int size = int.Parse(sizeOfMatrix);
            string[,] matrix = new string[size, size];

            int matrixLength = size*size;
            StreamReader reader = new StreamReader("../../../matrix.txt");

        }

        private static void CheckForIncorrectData(string sizeOfMatrix)
        {
            try
            {
                int number = int.Parse(sizeOfMatrix);
                Console.WriteLine("OK!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Ae, задай път дееб@!");
            }
            catch (Exception)
            {
                Console.WriteLine("Ае, кат' хората напиши един път нещо е дейб@!");
                Console.WriteLine("Каза ти се! На първия ред число => ЧИСЛО!");
            }
        }

        private static void PrintMatrix()
        {
            StreamReader text = new StreamReader("../../../matrix.txt");
            int element = 0;
            using (text)
            {
                string line;
                while ((line = text.ReadLine()) != null)
                {
                    Console.WriteLine("({0}) {1}", element, line);
                    element++;
                }
            }
        }

    }
}
