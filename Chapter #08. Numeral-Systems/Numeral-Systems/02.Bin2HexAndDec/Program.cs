using System;
using System.Text;

namespace _02.Bin2HexAndDec
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            string bin = "1111010110011110";
            long binA = 1111010110011110;
            string name = "Lyuben";

            Binary2Decimal(bin);

            Binary2Hexadecimal(bin);
        }

        private static void Binary2Hexadecimal(string bin)
        {
            string numberInHexadecimal = Convert.ToInt32(bin, 2).ToString("X");
            Console.WriteLine("Binary number: {0} => Hexadecimal number: {1}", bin, numberInHexadecimal);
        }

        private static void Binary2Decimal(string bin)
        {
            long numberInDecimal = Convert.ToInt64(bin, 2);
            Console.WriteLine("Binary number: {0} => Decimal number: {1}", bin, numberInDecimal);
            Console.WriteLine("====================================================");
        }

        private static void TryCatchExample(string anyStringHere)
        {
           try
           {
               WierdExample(anyStringHere);
            }
            catch (Exception)
            {
                Console.WriteLine("Глъф!!! Некоректна стойност еее еееееййййй!!!");
            }

        }

        private static bool TryParseExample(string anyStringHere)
        {
            long number;

            bool isNumerical = long.TryParse(anyStringHere, out number);

            Console.WriteLine("String {0} is numerical? => {1}", anyStringHere, isNumerical);

            return isNumerical;
        }

        private static void WierdExample(string bin)
        {
            double sum = 0;
            int numberOfDigits = bin.Length;
            long numberItself = long.Parse(bin);

            Console.WriteLine("bin.Length = " + numberOfDigits + " digits");

            for (int i = 0; i < numberOfDigits; i++)
            {
                int lastDigit = (int)(numberItself % 10); // Take the last digit

                Console.WriteLine("|{0, -16}| {1}", numberItself, lastDigit);

                sum += lastDigit * (Math.Pow(2, i));

                numberItself = numberItself / 10; // Remove the last digit
            }

            Console.WriteLine(sum);
        }

        private static void WierdExample(long binA)
        {
            double sum = 0;

            int numberOfDigits = binA.ToString().Length;

            Console.WriteLine("bin.Length = " + numberOfDigits + " digits");

            for (int i = 0; i < numberOfDigits; i++)
            {
                int lastDigit = (int)(binA % 10); // Take the last digit

                Console.WriteLine("|{0, -16}| {1}", binA, lastDigit);

                sum += lastDigit * (Math.Pow(2, i));

                binA = binA / 10; // Remove the last digit
            }

            Console.WriteLine(sum);
        }

    }
}
