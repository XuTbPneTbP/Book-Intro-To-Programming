using System;
using System.Collections;
using System.Collections.Generic;
using CountWords;

namespace CountWords
{
    public class ExamplesLogic : ComparerInterface
    {
        public static void Sample()
        {
            IDictionary<string, int> students = new SortedDictionary<string, int>();

            students.Add("john", 22);
            students.Add("Bugs Bunny", 76);
            students.Add("Franki", 11);

            foreach (var student in students)
            {
                Console.Write("Key: " + student.Key);
                Console.WriteLine(" ==> Value: " + student.Value);
                Console.WriteLine(student);
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++>");
            }
        }

        public static IDictionary<string, int> GetOccurences(string anyText)
        {
            // First we create string array splitting unnecessary chars
            string[] takeTheWords = anyText.Split(' ', '.', ',', '-', ';', '?', '!');

            // Next we create a dictionary in wich one we will show the value for each key

            //IDictionary<string, int> words = new SortedDictionary<string, int>();

            // If we apply CompareInterface class there will be no matter between capital and lowercase words. Each one will be treated like capital => 
            IDictionary<string, int> words = new SortedDictionary<string, int>(new ComparerInterface());

            foreach (var word in takeTheWords)
            {
                // Check if the string is empty and trim the whitespaces before and after
                if (!string.IsNullOrEmpty(word.Trim()))
                {
                    int count;
                    // We check if the word has value. If not => we set the counter back to zero. If this pair have value => then it wil skip the if statement and increase the counter
                    if (!words.TryGetValue(word, out count))
                    {
                        count = 0;
                    }
                    words[word] = count + 1;
                }
            }
            // After we are done, we return the sorted dictionary
            return words;
        }

        public static void PrintWordOccurences(IDictionary<string, int> wordOccurence)
        {
            // With one foreach loop we iterate trough the dictionary and print the key and the corresponding value for that key
            foreach (var keyValyePair in wordOccurence)
            {
                Console.WriteLine("Word {0} occures {1} times(s) in the text",
                    keyValyePair.Key, keyValyePair.Value);
            }
        }

    }
}
