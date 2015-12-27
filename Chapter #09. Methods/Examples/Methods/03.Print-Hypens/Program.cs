using System;

class Program
{
    static void Main()
    {
        for (int i=10 ; i>=0; i--)
        {
            PrintHypens(i);
        }
    }
    static void PrintHypens(int count)  //подаваме променлива от тип int на име count
    {
        Console.WriteLine(new string('-',count));        
    }
}

