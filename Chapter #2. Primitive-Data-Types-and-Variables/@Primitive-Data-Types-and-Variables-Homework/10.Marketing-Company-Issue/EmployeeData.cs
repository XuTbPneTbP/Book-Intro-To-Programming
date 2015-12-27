using System;

class EmployeeData
{
    static void Main()
     { 
        // • First name; 
        // • Last name;  
        // • Age (0...100); 
        // • Gender (m or f);  
        // • Personal ID number (e.g. 8306112507);
        // • Unique employee number (27560000…27569999);
         string firstName = "John";
         string lastName = "Rambo";
         sbyte employeeAge = 99;
         char  employeeGender = 'm';
         string employeeID = "8406194582";
         ulong uniqueEmployeeNumber = 27561313;

         Console.WriteLine("First name: {0} \nLast name: {1} \nAge: {2} \nGender: {3} \nPersonal ID number: {4} \nUnique Employee Number: {5}",
             firstName, lastName, employeeAge, employeeGender, employeeID, uniqueEmployeeNumber);


    }
}

