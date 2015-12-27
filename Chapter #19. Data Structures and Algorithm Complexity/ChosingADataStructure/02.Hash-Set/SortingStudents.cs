using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _02.Hash_Set
{
    class SortingStudents
    {
        static void Main()
        {
            Console.WriteLine("*...");

            StreamReader reader = new StreamReader("../../../../Students & Courses.txt");
            ReadTextFile(reader);

            Console.WriteLine("*...");
        }

        private static void ReadTextFile(StreamReader reader)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, List<Student>> courses = new Dictionary<string, List<Student>>();

            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] data = line.Split(new[] {'|'});
                    string firstName = data[0].Trim();
                    string lastName = data[1].Trim();
                    string courseName = data[2].Trim();

                    List<Student> students;
                    // Ако няма такъв KEY: (курс) със такъв Value: лист от студенти = > създаваме нов
                    if (!courses.TryGetValue(courseName, out students))
                    {
                        students = new List<Student>();
                        courses.Add(courseName, students);
                    }
                    // След като вече имаме курс със лист от студенти = > създаваме си нов обект чрез получените данни от data[] масива и го добавяме в листа
                    Student rookie = new Student(firstName, lastName);
                    students.Add(rookie);
                }
            }

            foreach (var currentCourse in courses.Keys)
            {
                Console.WriteLine("Course " + currentCourse + ":");

                List<Student> studentsInCourse = courses[currentCourse];
                foreach (Student student in studentsInCourse)
                {
                    Console.WriteLine("\t{0}", student);
                }
            }

        }

    }
}
