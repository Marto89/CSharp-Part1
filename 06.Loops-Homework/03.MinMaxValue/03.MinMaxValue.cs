using System;
using System.Linq;

class MinMaxValue
{
    static void Main()
    {
        Console.Write("Enter a number of the integers: ");
        int n = int.Parse(Console.ReadLine());

        int [] integers=new int[n];
        int counter=1;

        for (int i= 0; i <n; i++)
        {
            Console.Write("Enter {0}: ",counter);
            integers[i] = int.Parse(Console.ReadLine());
            counter++;
        }

        int min = integers.Min();
        Console.WriteLine("The minimal integer is : {0}",min);

        int max = integers.Max();
        Console.WriteLine("The maximal integer is : {0}", max);
    }
}
