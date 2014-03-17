using System;

class CoffeeMachine
{
    static void Main()
    {
        checked
        {
            int coinN1 = int.Parse(Console.ReadLine());
            int coinN2 = int.Parse(Console.ReadLine());
            int coinN3 = int.Parse(Console.ReadLine());
            int coinN4 = int.Parse(Console.ReadLine());
            int coinN5 = int.Parse(Console.ReadLine());

            double amount = double.Parse(Console.ReadLine());
            double priceP = double.Parse(Console.ReadLine());

            double priceN1 = coinN1 * 0.05;
            double priceN2 = coinN2 * 0.10;
            double priceN3 = coinN3 * 0.20;
            double priceN4 = coinN4 * 0.50;
            double priceN5 = coinN5 * 1.00;


            double moneyMaschine = priceN1 + priceN2 + priceN3 + priceN4 + priceN5;
            double change = moneyMaschine - (amount - priceP);
            double moreMoney = priceP - amount;
            double no = amount - (moneyMaschine + priceP);

            if (moneyMaschine > amount - priceP && amount - priceP >= 0)
            {
                Console.WriteLine("Yes {0:F2}", change);
            }
            else if (priceP - amount >= 0)
            {
                Console.WriteLine("More {0:F2}", moreMoney);
            }
            else if (priceP - amount <= 0)
            {
                Console.WriteLine("No {0:F2}", no);
            }
        }
    }
}

