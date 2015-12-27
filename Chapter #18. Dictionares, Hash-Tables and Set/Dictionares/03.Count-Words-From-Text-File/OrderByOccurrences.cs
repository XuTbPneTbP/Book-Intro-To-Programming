using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.Count_Words_From_Text_File
{
    class WordsComparer : IComparer<string>
    {
        int IComparer<string>.Compare(string x, string y)
        {
            return string.Compare(x, y, true);
        }
    }

    class OrderByOccurrences
    {
        static void Main()
        {
            //PrintTextFromFile();

            var wordOccurencesInFile = WordOccurencesInFile();
            var sorted = wordOccurencesInFile.OrderBy(w => w.Value);
            foreach (var word in sorted)
            {
                Console.WriteLine("Word => |{0, 25}| found |{1,-3}| time(s)", word.Key, word.Value);
            }
        
        }

        public static IDictionary<string, int> WordOccurencesInFile()
        {
            IDictionary<string, int> wordOccurencesInFile = new SortedDictionary<string, int>(new WordsComparer());
            StreamReader reader = new StreamReader("../../../words.txt");

            using (reader)
            {
                string line = reader.ReadLine().Trim();
                while (line != null)
                {
                    string[] wordsFromFile = line.Split(' ', '.', '=', '!', ';', '\"', '|', '_', '/', '\'', '<', '>', '(', ')',
                        '{', '}', '[', ']', '+', ',');
                    foreach (var word in wordsFromFile)
                    {
                        int count;
                        if (!wordOccurencesInFile.TryGetValue(word, out count))
                        {
                            count = 0;
                        }
                        wordOccurencesInFile[word] = count + 1;
                    }
                    line = reader.ReadLine();
                }
            }
            return wordOccurencesInFile;
        }

        private static void PrintTextFromFile()
        {
            StreamReader reader = new StreamReader("../../../words.txt");
            using (reader)
            {
                int counter = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine("|Line {0}| => {1}", counter, line);
                    counter++;
                    line = reader.ReadLine();
                }

            }

        }

    }
}
