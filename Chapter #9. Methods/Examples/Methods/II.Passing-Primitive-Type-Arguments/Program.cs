using System;

class Program
{
    static void Main()
    {
        int newNumberParameter = 6;        
        PrintNumber(newNumberParameter);
        Console.WriteLine("In the Main() method newNumberparameter is: {0} ",newNumberParameter);
    }

    static void PrintNumber(int numberParameter)
    {
        //Modify the primitive-type parameter
        numberParameter = 12;
        
        Console.WriteLine("In PrintNumber() method, after "+" modification, numberParameter is {0}",numberParameter);
    }
}

