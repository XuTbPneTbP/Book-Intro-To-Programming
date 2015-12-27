using System;
using System.IO;

namespace _05.Occurence_Of_A_Substring
{
    class Program
    {
        private static void Main()
        {
            // SubstringDemo();

            string filePath = "../../../numbers.txt";
            string searchedWord = "mumber";

            try
            {
                StreamReader textReader = new StreamReader(filePath);
                using (textReader)
                {
                    int occurences = 0;
                    string line = textReader.ReadLine();

                    while (line != null)
                    {
                        int index = line.IndexOf(searchedWord);
                        while (index != -1)
                        {
                            occurences++;
                            // Check the next one
                            index = line.IndexOf(searchedWord, (index + 1));
                        }

                        line = textReader.ReadLine();
                    }

                    Console.WriteLine("The word: {0} is found {1} time(s)", searchedWord, occurences);
                }

            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can't find the file {0}", filePath);
            }

        }

        private static void SubstringDemo()
        {
            // The input string.
            string s = "I have a cat";

            // Loop through all instances of the letter a.
            int i = 0;
            while ((i = s.IndexOf('a', i)) != -1)
            {
                // Print out the substring.
                Console.WriteLine(s.Substring(i));

                // Increment the index.
                i++;
            }
        }


    }
}
