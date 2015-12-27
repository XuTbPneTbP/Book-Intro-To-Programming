using System;
using System.Text;

class InvokeMethod
{
   
    static void Main()
    {       
        JohnJeylogo();
        ArrOfNumbers();        
        CompanyInfo();
    }
    static void JohnJeylogo()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("John Jey Rambo  '\u00a2\'");
    }
    static void ArrOfNumbers()
    {
        Console.Write("Enter arr lenght < 10 :  ");
        int lenght = int.Parse(Console.ReadLine());
        int[] arr = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("arr index [{0}] = ",i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        foreach (var number in arr)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
    static void CompanyInfo()
    {
        Console.WriteLine("John Jey Rambo will break you neck.Myaxaxaxxa!!!");
        Console.WriteLine();
    }    
}

