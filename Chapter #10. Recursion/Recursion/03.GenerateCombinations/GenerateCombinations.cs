using System;

class GenerateCombinations
{
    static void Main()
    {
        Console.Write("How much elements do you want to combinate: ");
        int elementsToBeCombinated = int.Parse(Console.ReadLine());
        int startNum = 5;
        int endNum = 10;
        int[] arr = new int[elementsToBeCombinated];
        Combinations(arr,0,startNum,endNum);
    }
    static void Combinations(int[] array, int index, int startNum, int endNum)
    {
        if (index >= array.Length)
        {   // combination is find so...print it!
            Console.WriteLine("(" + String.Join(", ",array) + ")");
        }
        else
        {
            for (int i = startNum; i <= endNum; i++)
            {
                array[index] = i;
                Combinations(array,index + 1, i + 1, endNum);
            }
        }
    }
}

