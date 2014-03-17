using System;

class EmployeesRecord
{
    static void Main()
    {
        Console.Title = ("10.EmployeesRecord");
        Console.WriteLine("Enter first Name:");
        string firstName = (Console.ReadLine());
        Console.WriteLine("Enter Family Name: ");
        string familyName = (Console.ReadLine());
        Console.WriteLine("Enter Age:");
        var age = (Console.ReadLine());
        Console.WriteLine("Enter gender f/m:");
        var gender = (Console.ReadLine());
        Console.WriteLine("Enter idNumber:");
        var idNumber = (Console.ReadLine());
        Console.WriteLine("Enter uniqueEmployeeNumber:");
        var uniqueEmployeeNumber = (Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Personal Information about :\n\nFirst Name: {0}\nFamily Name: {1}\nAge: {2}\nGender: {3}\nID Number: {4}\nUnique Employee Number: {5}", firstName, familyName, age, gender, idNumber, 27560000 + uniqueEmployeeNumber);
        Console.WriteLine();
    }
}