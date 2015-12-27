using System;

class FloatOrDouble
{
    static void Main()
    {    //Which of the following values can be assigned to a variable of type float
        // and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
        // Write a program to assign the numbers in variables and print them to ensure no precision is lost.
        double first = 34.567839023d;
        float  second = 12.345f;
        double third = 8923.1234857d;
        float fourth = 3456.091f;
        Console.WriteLine("double {0} \nfloat {1} \ndouble {2} \nfloat {3}",first, second, third, fourth);
    }
}

