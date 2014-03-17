using System;

class CalculatesAndPrintsNumbers
{
    static void Main()
    {
        Console.Write("Enter the count of numbers that you want to sum: ");
        int n = int.Parse(Console.ReadLine());

        int currentNumber = 0;
        long sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter:");
            currentNumber = int.Parse(Console.ReadLine());
            sum = sum + currentNumber;
            
        }
        Console.WriteLine("The sum of all numbers is: {0}",sum);
    }
}
