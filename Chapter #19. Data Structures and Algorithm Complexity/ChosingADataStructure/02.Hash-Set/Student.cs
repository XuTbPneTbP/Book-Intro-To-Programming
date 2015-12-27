using System;

namespace _02.Hash_Set
{
    public class Student : IComparable<Student>
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public int CompareTo(Student someStudent)
        {
            int result = lastName.CompareTo(someStudent.lastName);
            if (result == 0)
            {
                result = firstName.CompareTo(someStudent.firstName);
            }
            return result;
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
