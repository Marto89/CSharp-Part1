using System;

class PrimePositiveInteger
{
    static void Main()
    {
        Console.Title = "07.PrimePositiveInteger";
        Console.Write("Enter positive integer number till 100: ");
        int n = int.Parse(Console.ReadLine());

        if ((n > 1) && (n <= 100))
        {

            if ((n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0) || n==2 || n==3 || n==5 || n==7)
            {
                Console.WriteLine(" The number  " + n + "  is prime!");
            }
            else
            {
                Console.WriteLine(" The number  " + n + "  isn't prime! ");
            }
        }
        else
        {
            Console.WriteLine("This number is not positive integer till 100!");
        }
    }
}
