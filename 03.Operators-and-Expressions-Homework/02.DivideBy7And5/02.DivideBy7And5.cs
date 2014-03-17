using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Title = ("02.DivideBy7And5");
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        bool devide = number % 5 == 0 && number % 7 == 0;
        Console.WriteLine(devide);
    }
}
