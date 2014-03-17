using System;

class PrintChange
{
    static void Main(string[] args)
    {
        float available = 0;

        available = available + (int.Parse(Console.ReadLine()) * 0.05f);
        available = available + (int.Parse(Console.ReadLine()) * 0.10f);
        available = available + (int.Parse(Console.ReadLine()) * 0.20f);
        available = available + (int.Parse(Console.ReadLine()) * 0.50f);
        available = available + (int.Parse(Console.ReadLine()) * 1.00f);

        float inputed = float.Parse(Console.ReadLine());
        float price = float.Parse(Console.ReadLine());

        if (inputed < price)
        {
            Console.WriteLine("More {0:F2}", (price-inputed));
        }
        else if (inputed == price)
        {
            Console.WriteLine("Yes {0:F2}", available);
        }
        else if (inputed > price)
        {
            Console.WriteLine("{0} {1:F2}",((available<(inputed-price))? "No": "Yes"), Math.Abs(available - (inputed - price)));
        }
    }
}

