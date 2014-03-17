using System;

class OddOrEven
{
    static void Main()
    {
        Console.Title = ("01.OddOrEven");
        Console.WriteLine("Enter your number:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)       
            Console.WriteLine("This number is even!"); 
        else
            Console.WriteLine("This number is odd!");
        
    }
}
