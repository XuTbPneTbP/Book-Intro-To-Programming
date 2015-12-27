using System;

class DividevByNminusKfactorial
{
static void Main()
    {
        Console.Write("!N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("!K = ");
        int k = int.Parse(Console.ReadLine());
        decimal factorialN = 1;
        decimal factorialK = 1;
        decimal factorialNminusK = 1;
        decimal lenghtNK = n - k;

        for (int i = 0; i <= n + 1; i++)
        {
            for (int j = 0; j <= k + 1; j++)
            {
                if (k < 1)
                {
                    break;
                }
                factorialK *= k;
                k--;
            }
            factorialN *= n;
            n--;
        }

        decimal counter = lenghtNK;
        for (int i = 0; i <= counter+1; i++)
        {
            if (counter < 1)
            {
                break;
            }
            factorialNminusK *= counter;
            counter--;
        }

        Console.WriteLine("***********************************************");
        Console.WriteLine("!N = " + factorialN);
        Console.WriteLine("!K = " + factorialK);
        Console.WriteLine("!N*!K = " + (factorialN * factorialK));
        Console.WriteLine("(N-K) = " + lenghtNK);
        Console.WriteLine("(N-K)! = " + factorialNminusK);

        Console.WriteLine("!N*!K/(N-K)! = {0}", (factorialN * factorialK) / factorialNminusK);
    }
    
}

