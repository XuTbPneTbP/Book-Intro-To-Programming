using System;

class IsThirdNumber7
{
    static void Main()
    {
        Console.WriteLine("Enter a number and it will be checked if third digit is 7: ");
        int givenNumber = int.Parse(Console.ReadLine());
        int value = ((givenNumber / 100) % 10);
      
        if (value == 7)
        {
            Console.WriteLine("True,the third digit from right to left is 7");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

