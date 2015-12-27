using System;

class WithNestedForLoops
{
    static void Main()
    {
        string[,] names = 
        {
            {"Гошо ", "Пешо ", "Dragan"},
            {"Стефан ", "Джон Джей ", "Пръдлю"},
        };

        for (int i = 0; i < names.GetLength(0); i++)
        {
            for (int j = 0; j < names.GetLength(1); j++)
            {
                Console.Write(names[i,j]);
            }
            Console.WriteLine();
        }
    }
}

