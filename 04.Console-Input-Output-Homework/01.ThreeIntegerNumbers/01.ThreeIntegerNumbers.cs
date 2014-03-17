using System;

class ThreeIntegerNumbers
{
    static void Main()
    {
        Console.Title = "01.ThreeIntegerNumbers";
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        int sum = a + b + c;
        Console.WriteLine(sum);
    }
}