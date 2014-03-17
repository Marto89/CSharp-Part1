using System;

class Program
{
    static void Main()
    {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
                if (n == 1)
                 {
                    Console.WriteLine(numbers[i]);
                    return;
                }
            }
            Array.Sort(numbers);
            if (numbers[0] != numbers[1])
            {
                Console.WriteLine(numbers[0]);
                return;
            }
            long sum = 0;
            int counter = 1;
            for (int i = 1; i < n - 1; i++)
            {
                sum = numbers[i];
                if (sum == numbers[i - 1])
                {
                    counter++;
                }
                else
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(numbers[i-1]);
                        return;
                    }
                    else
                    {
                        counter = 1;
                    }
                }
            }
        Console.WriteLine(numbers[n - 1]);
    }
}