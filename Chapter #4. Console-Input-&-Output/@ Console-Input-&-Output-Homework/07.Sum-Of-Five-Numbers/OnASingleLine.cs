using System;

class OnASingleLine
{
    static void Main()
    {
        Console.Write("Enter five numbers separated with space: ");
        string[] fiveNumbers = Console.ReadLine().Split();
        double number1 = Convert.ToDouble(fiveNumbers[0]);
        double number2 = Convert.ToDouble(fiveNumbers[1]);
        double number3 = Convert.ToDouble(fiveNumbers[2]);
        double number4 = Convert.ToDouble(fiveNumbers[3]);
        double number5 = Convert.ToDouble(fiveNumbers[4]);
        double sumOfNumbers = number1 + number2 + number3 + number4 + number5;
        Console.WriteLine("The sum of all five numbers is: |{0:c}|", sumOfNumbers);
        if ((number1>number2) && (number1>number3) && (number1>number4) && (number1>number5))
        {           
            Console.WriteLine("The greater is {0}", number1);
        }
        else if ((number2 > number1) && (number2 > number3) && (number2 > number4) && (number2 > number5))
        {
            Console.WriteLine("The greater is {0}", number2);
        }
        else if ((number3 > number1) && (number3 > number2) && (number3 > number4) && (number3 > number5))
        {
            Console.WriteLine("The greater is {0}", number3);
        }
        else if ((number4 > number1) && (number4 > number2) && (number4 > number3) && (number2 > number5))
        {
            Console.WriteLine("The greater is {0}", number4);
        }
        else if ((number5 > number1) && (number5 > number2) && (number5 > number3) && (number5 > number4))
        {
            Console.WriteLine("The greater is {0}", number5);
        }
    }
}

