using System;

class WithInput
{
    static void Main()
    {
        Console.WriteLine("Enter the requested information!");
        Console.WriteLine("---------------------------------------------");

        Console.Write("Company name: ");
        string companyName = Convert.ToString(Console.ReadLine());

        Console.Write("Company address: ");
        string companyAddress = Convert.ToString(Console.ReadLine());

        Console.Write("Company phone number: ");
        long companyNumber = long.Parse(Console.ReadLine());

        Console.Write("Company web site: ");
        string companyWebSite = Convert.ToString(Console.ReadLine());

        Console.Write("Manager first name: ");
        string managerFirstName = Convert.ToString(Console.ReadLine());

        Console.Write("Manager last name: ");
        string managerLastName = Convert.ToString(Console.ReadLine());

        Console.Write("Manager phone number: ");
        long managerPhone = long.Parse(Console.ReadLine());

        string info = "INFO: ";

        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine();

        Console.WriteLine("{0}", info);

        Console.Write("Company: |{0, 30}| \nAddress: |{1, 30}| \nCompany number: |{2, 30}| " +
                      "\nWeb site: |{3, 30}| \nManager: |{4} {5}| \nManager phone: |{6, 30}|",
                      companyName, companyAddress, companyNumber,
                      companyWebSite, managerFirstName, managerLastName, managerPhone);

        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine();
    }
}