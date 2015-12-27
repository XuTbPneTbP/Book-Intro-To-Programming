using System;
using UR2PPR;

namespace _01.StreamReader
{
    using System.IO;
    class Program : UniversalFilePathResolver
    {
        static void Main()
        {
            string unknownPath = @"D:\PROGRAMING\Books\Questions.txt";
            StreamReader interviewQuestions = new StreamReader(unknownPath);

            int lineNumber = 0;

            string currentLine = interviewQuestions.ReadLine();

            while (currentLine != null)
            {
                lineNumber++;

                Console.WriteLine("Current line: {0} => {1}", lineNumber, currentLine);

                currentLine = interviewQuestions.ReadLine();

            }

            interviewQuestions.Close();

        }
    }
}
