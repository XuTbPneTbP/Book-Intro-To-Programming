using System;

class SixNestedForLoops
{
    static void Main()
    {
        int count = 1;
        for (int firstNumber = 1; firstNumber <= 44; firstNumber++)
        {
            for (int secondNumber = firstNumber + 1; secondNumber <= 45; secondNumber++)
            {
                for (int thirdNumber = secondNumber + 1; thirdNumber <= 46; thirdNumber++)
                {
                    for (int fourthNumber = thirdNumber + 1; fourthNumber <= 47; fourthNumber++)
                    {
                        for (int fifthNumber = fourthNumber + 1; fifthNumber < 48; fifthNumber++)
                        {
                            for (int sixth = fifthNumber + 1; sixth < 49; sixth++)
                            {
                                //Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber + " " + fourthNumber +
                                //    " " + fifthNumber + " " + sixth);
                                count++;
                            }                         
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}

