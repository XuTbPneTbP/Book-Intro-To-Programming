using System;

class WithPositiveInteger
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        double number = double.Parse(Console.ReadLine());
        double  divider = 2;
        double maxDivider = Math.Sqrt(number);
        
        bool prime = true;
        if (prime && (divider < maxDivider))
        {
            if (number % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        Console.WriteLine(prime);                   
    }

}


