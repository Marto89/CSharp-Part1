using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter a positive integer number N(N<20): ");
        int n = int.Parse(Console.ReadLine());

        for (int row = 1 ; row <=n; row++)
        {
            for (int column = 1; column<=n; column++)
            {
                Console.Write(((row+column)-1).ToString().PadLeft(3));
                  
            }               
            Console.WriteLine();
        }
    }
}
