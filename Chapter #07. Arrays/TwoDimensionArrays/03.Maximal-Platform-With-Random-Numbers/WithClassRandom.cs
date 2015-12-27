using System;

class WithClassRandom
{
    static void Main()
    {
        Random случайниЧисла = new Random();
        //Създаваме си матрица с големина редове = 10, колони = 10 --> row = 10, col = 10
        var матрица = new int [10,10];
        //За да я напълним използваме два вложени цикъла и използваме Random класа. 
        for (int row = 0; row < матрица.GetLength(0); row++)
        {
            for (int col = 0; col < матрица.GetLength(1); col++)
            {//Пълним всеки индекс с случайно число от 1 до 25
                матрица[row, col] = случайниЧисла.Next(1, 6);
            }
        }
        //Визуализираме матрицата
        for (int row = 0; row < матрица.GetLength(0); row++)
        {
            for (int col = 0; col < матрица.GetLength(1); col++)
            {               
                Console.Write("{0} ",матрица[row,col]);
            }
            Console.WriteLine();
        }
        //Пресмятаме максималната платформа 2х2. В случая пускаме циклите да въртят бяз последния ред и последната колона, понеже ще излязат извън границите на матрицата.
        int bestSum = int.MinValue;
        int sum = 0;
        int bestRow = 0;
        int bestCol = 0;        
        for (int row = 0; row < матрица.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < матрица.GetLength(1) - 1; col++)
            {
                sum = матрица[row, col] + матрица[row, col + 1]
                       + матрица[row + 1, col] + матрица[row + 1, col + 1];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }            
        }
        //Принтваме резултата
        Console.WriteLine("The best platform is:");
        Console.WriteLine(" '{0}' '{1}'", матрица[bestRow, bestCol], матрица[bestRow, bestCol + 1]);
        Console.WriteLine(" '{0}' '{1}'", матрица[bestRow + 1, bestCol], матрица[bestRow + 1, bestCol + 1]);
        Console.WriteLine("The maximum sum is {0}", bestSum);
    }    
}

