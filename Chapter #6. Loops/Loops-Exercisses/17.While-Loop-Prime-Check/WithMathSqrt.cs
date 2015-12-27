using System;
using System.Text;

namespace _17.While_Loop_Prime_Check
{
    class WithMathSqrt
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool correctInput = false;

            Console.Write("Enter positive number: ");

            CheckForCorrectInput(correctInput);

            Console.WriteLine("Bye Bye");

        } 
        // => End

        private static void CheckForCorrectInput(bool correctInput)
        {
            string input = "";
            while (correctInput != true)
            {
                input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                correctInput = TryCatchInputParser(input);

            } // => End of While loop

        }
        // +> End

        private static bool TryCatchInputParser(string input)
        {
            bool correctInput = false;

            try
            {
                int number = int.Parse(input);

                if (number <= 0)
                {
                    Console.WriteLine("Позитивно число, бе дейб@!!");
                }

                if (number > 0)
                {
                    PrimeNumberChecker(number);

                    correctInput = true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Число уе, ей....!");
            }

            return correctInput;
        }
        // => End

        private static void PrimeNumberChecker(int number)
        {
            int divider = 2;
            int maxDivider = (int) Math.Sqrt(number);
            bool prime = true;

            while (prime && (divider <= maxDivider))
            {
                prime = CatchNotPrimeNumbers(number, divider, prime);

                divider++;

            } 
            // => End of While loop

            PassNotPrimeNumbersCheck(number, prime, divider);

        }
        // => End

        private static bool CatchNotPrimeNumbers(int number, int divider, bool prime)
        {
            if (number % divider == 0)
            {
                PrintNotPrimeNumber(number, divider);

                prime = false;
            }
            return prime;
        }
        // => End

        private static void PrintNotPrimeNumber(int number, int divider)
        {
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("Wrong! The number is not prime!");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("Square Root: \t|{0, 5}|", Math.Sqrt(number));
            Console.WriteLine("Current Divider |{0, 5}|", divider);
        }
        // => End

        private static void PassNotPrimeNumbersCheck(int number, bool prime, int divider)
        {
            if (prime)
            {
                PrintPrimeNumber(number, divider);
            }
        }
        // => End

        private static void PrintPrimeNumber(int number, int divider)
        {
            int reminder = number%divider;
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("This number is prime |{0, 5}|", number);
            Console.WriteLine("Square Root:\t     |{0, 5:f3}|", Math.Sqrt(number));
            Console.WriteLine("Number % Divider =   |{0, 5}|", reminder);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }
        // => End

    }
}
