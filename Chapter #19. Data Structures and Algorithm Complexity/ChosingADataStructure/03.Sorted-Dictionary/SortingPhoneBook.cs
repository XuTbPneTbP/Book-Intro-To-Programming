using System;
using System.Collections.Generic;
using System.IO;

namespace _03.Sorted_Dictionary
{
    class SortingPhoneBook
    {
        private const string PhoneBookFileName = "../../../../PhoneBook.txt";
        private const string QueriesFileName = "../../../../Queries.txt";

        static Dictionary<string, List<string>> phoneBook = new Dictionary<string, List<string>>(); 

        static void Main()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Phonebook");
            Console.WriteLine("++++++++++++++++++++++++++++++");

           // StreamReader reader = new StreamReader("../../../../Students & Courses.txt");

            Console.WriteLine("*");
            //PrintPeopleByTown(reader);
            ReadPhonebook();
            Console.WriteLine("*");


        }

        static void ReadPhonebook()
        {
           StreamReader reader = new StreamReader(PhoneBookFileName);
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] lineData = line.Split(new char[] {'|'});

                    string names = lineData[0].Trim();
                    string town = lineData[2].Trim();

                    string[] nameTokens = names.Split(new char[] {' ', '\t'});

                    foreach (var name in nameTokens)
                    {
                        Add2PhoneBook(name, line);
                        string nameAndTown = CombineNameAndTown(town, name);
                        Add2PhoneBook(nameAndTown, line);
                    }
                }
            }

            foreach (var entry in phoneBook)
            {
                Console.WriteLine(entry.Key);
            }
        }

        static string CombineNameAndTown(string town, string name)
        {
            return name + " from " + town;
        }

        static void Add2PhoneBook(string name, string readerLineData)
        {
            name = name.ToLower();
            List<string> lineData;

            if (!phoneBook.TryGetValue(name, out lineData))
            {
                lineData = new List<string>();
                phoneBook.Add(name, lineData);
            }
            lineData.Add(readerLineData);
        }

        private static void PrintPeopleByTown(StreamReader reader)
        {
            SortedDictionary<string, SortedDictionary<string, string>> phonesByTown =
                new SortedDictionary<string, SortedDictionary<string, string>>();
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] phoneBookData = line.Split(new char[] {'|'});
                    string firstName = phoneBookData[0].Trim();
                    string town = phoneBookData[3].Trim();
                    string phoneNumber = phoneBookData[4].Trim();

                    SortedDictionary<string, string> phoneBook;
                    // If there is no town like a key = . we create new city in phonesByTown
                    if (!phonesByTown.TryGetValue(town, out phoneBook))
                    {
                        // Create & add new phonebook with parameters for it
                        phoneBook = new SortedDictionary<string, string>();
                        phonesByTown.Add(town, phoneBook);
                    }
                    phoneBook.Add(firstName, phoneNumber);
                }
            }

            foreach (var town in phonesByTown.Keys)
            {
                Console.WriteLine("Town " + town + ":");
                SortedDictionary<string, string> namesAndPhohes = phonesByTown[town];

                foreach (var data in namesAndPhohes)
                {
                    string name = data.Key;
                    string phone = data.Value;
                    Console.WriteLine("\t{0} = > |{1}|", name, phone);
                }
            }
        }

    }
}
