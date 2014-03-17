 using System;

class CoffeeMachine
{
    static void Main()
    {
        decimal[] machineTrays = new decimal[5];
        for (int i = 0; i < 5; i++)
        {
            machineTrays[i] = decimal.Parse(Console.ReadLine());
        }

        decimal amount = decimal.Parse(Console.ReadLine());
        decimal price = decimal.Parse(Console.ReadLine());
        decimal sumInTrays = 0.00m;
        decimal difference = 0.00m;

        machineTrays[0] = machineTrays[0] * 0.05m;
        machineTrays[1] = machineTrays[1] * 0.10m;
        machineTrays[2] = machineTrays[2] * 0.20m;
        machineTrays[3] = machineTrays[3] * 0.50m;
        machineTrays[4] = machineTrays[4] * 1.00m;

        for (int i = 0; i <= 4; i++)
        {
            sumInTrays += machineTrays[i];
        }

        if (amount == price)
        {
            Console.WriteLine("Yes {0:F2}", sumInTrays);
        }
        else if (amount < price)
        {
            Console.WriteLine("More {0:F2}", difference = (price - amount));
        }
        else if (amount > price)
        {
            if (sumInTrays < (amount - price))
            {
                Console.WriteLine("No {0:F2}", difference = (amount - (sumInTrays + price)));
            }
            else
            {
                Console.WriteLine("Yes {0:F2}", difference = (sumInTrays - (amount - price)));
            }
        }
    }
}
