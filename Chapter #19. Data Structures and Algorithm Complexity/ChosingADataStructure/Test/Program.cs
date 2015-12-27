using System;
using System.Collections.Generic;

namespace Test

{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string slash = Console.ReadLine();

            // Обръщаме към масив от char-Ове
            char[] charArray = input.ToCharArray();

            // Взимаме му дължината, за да ни е по удобно като ни потрябва
            int arrayLength = charArray.Length;

            // Сетваме си нов char масив с получената дължина
            char[] extractLastDigitFromChar = new char[arrayLength];

            // Понеже не се знае колко ще са елементите след разбиването стойностите на char-овете = >  в случая 36, трябва да може да добавяме елементи без да зме ограничени от определена дължина, В случая List<int> няма фоксирана дължина в началото като при масива. Начинът на работа е подобен. Тук в случая само декларираме списъка
            List<int> newNumber = new List<int>();
       

            for (int i = 0; i < arrayLength; i++)
            {
                char lastDigit = Convert.ToChar(charArray[i] % 10);
                // Тук вече сме взели всички последни цифри
                extractLastDigitFromChar[i] = Convert.ToChar(lastDigit);
            }

            // Тук си принтираме масива, за да се убедим, че сме си взели данните правилно
//            foreach (var digit in extractLastDigitFromChar)
//            {
//                Console.WriteLine((int)digit);
//            }

            for (int i = 0; i < extractLastDigitFromChar.Length; i++)
            {
                if ((int)extractLastDigitFromChar[i] % 2 == 0)
                {
                    // Тук в result влиза 6*6 = 36 = > проверяваш дали е двуцифрено и ако е го разбиваш
                    int result = (char) (extractLastDigitFromChar[i]*extractLastDigitFromChar[i]);

                    string resultLength = result.ToString();
                    if (resultLength.Length > 1)
                    {
                        int lastDigit = result%10;  // => 6
                        int previousDigit = (result/10)%10; // = > 3

                        // Внимавай за реда на добавяне!!
                        newNumber.Add(previousDigit);
                        newNumber.Add(lastDigit);
                    }

                    newNumber.Add(result);
                }
                else if ((int)extractLastDigitFromChar[i] % 2 != 0 && (i == 0))
                {
                    int result =
                        (char)
                            (Convert.ToInt32(extractLastDigitFromChar[i + 1]) +
                             Convert.ToInt32(extractLastDigitFromChar[i]));
                    newNumber.Add(result);
                }
                else if ((int)extractLastDigitFromChar[i] % 2 != 0 && (i == extractLastDigitFromChar.Length - 1))
                {
                    int result =
                        (char)
                            (Convert.ToInt32((extractLastDigitFromChar[i - 1]) +
                                             Convert.ToInt32(extractLastDigitFromChar[i])));
                    newNumber.Add(result);
                }
                else if (((int)extractLastDigitFromChar[i] % 2 != 0) && (i != 0) && (i != extractLastDigitFromChar.Length - 1))
                {
                    int result =
                        (char)
                            (Convert.ToInt32(extractLastDigitFromChar[i - 1]) +
                             Convert.ToInt32(extractLastDigitFromChar[i + 1]) +
                             Convert.ToInt32(extractLastDigitFromChar[i]));
                    newNumber.Add(result);
                }

            }

            char[] listNewNumber2CharArray = new char[newNumber.Count - 1];

            for (int i = 0; i < listNewNumber2CharArray.Length; i++)
            {
                listNewNumber2CharArray[i] = (char) newNumber[i];
            }

            int matrixSize = newNumber.Count - 1;
            char[,] matrix = new char[matrixSize, matrixSize];
            if (slash == @"\")
            {
                for (int i = 0; i < matrixSize; i++)
                {
                    matrix[i, i] = listNewNumber2CharArray[i];
                }
            }
            else
            {

                for (int i = 0; i < matrixSize; i++)
                {
                    matrix[matrixSize - i - 1, i] = listNewNumber2CharArray[i];
                }
            }
            char[] characters = newNumber.ToString().ToCharArray();

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {

                    Console.Write((int)matrix[i, j] + " ");

                }
                Console.WriteLine();
            }

        }
    }
}
