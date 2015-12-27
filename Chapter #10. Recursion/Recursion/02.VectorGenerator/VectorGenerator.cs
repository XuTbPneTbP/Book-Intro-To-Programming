using System;

class VectorGenerator
{
    static void Main()
    {
        int n = 3;
        GeneratorZeroesOnes(new int[n], 0);
    }
    public static void GeneratorZeroesOnes(int[] vector, int currentIndex)
    {
        if (currentIndex == vector.Length)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i]);
            }
            Console.WriteLine();
            return;
        }
        vector[currentIndex] = 0;
        GeneratorZeroesOnes(vector, currentIndex + 1);

        vector[currentIndex] = 1;
        GeneratorZeroesOnes(vector, currentIndex + 1);
    }
}

