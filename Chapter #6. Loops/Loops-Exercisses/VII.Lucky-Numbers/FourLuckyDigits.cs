using System;

namespace VII.Lucky_Numbers
{
    class FourLuckyDigits
    {
        static void Main()
        {
            // Loop for each digit. At inner print the value match (A+B) = (C+D)
            // - Outer loop represents the thousands and starts with 1 till 9 included
            // - Inner loops represents: hundreds, tens and units. Starts from 0 till 9 included
            int innerMostCounter = 0;
            int unitsCounter = 0;
            int tensCounter = 0;
            int hundredsCounter = 0;
            int thousandsCounter = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 0; d <= 9; d++)
                        {
                            if ((a + b) == (c + d))
                            {
                                string output = a + " " + b + " " + c + " " + d;
                                Console.WriteLine(output);
                                innerMostCounter++;
                            }
                            unitsCounter++;
                        }

                        tensCounter++;
                    }

                    hundredsCounter++;
                }

                thousandsCounter++;
            }

            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("Inner => " + innerMostCounter);
            Console.WriteLine("Units => " + unitsCounter);
            Console.WriteLine("Units => " + tensCounter);
            Console.WriteLine("Units => " + hundredsCounter);
            Console.WriteLine("Units => " + thousandsCounter);

        }
    }
}
