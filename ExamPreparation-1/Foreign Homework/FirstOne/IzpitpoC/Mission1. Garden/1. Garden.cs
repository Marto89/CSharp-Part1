using System;

class Garden
{
    static void Main()
    {
        int tomatoSeads = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());

        int cucumberSeads = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());

        int potatoSeads = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());

        int carrotSeads = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());

        int cabbageSeads = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());

        int beansSeads = int.Parse(Console.ReadLine());


        double totalCosts = tomatoSeads*0.5 + cucumberSeads*0.4 + potatoSeads*0.25 + carrotSeads*0.6 + cabbageSeads*0.3+beansSeads*0.4;

        int mainArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;

        int beansArea = 250 - mainArea;

        if (mainArea < 250)
        {
            Console.WriteLine("Total costs: {0:F2}",totalCosts);
            Console.WriteLine("Beans area: {0}",beansArea);
        }
        if (mainArea > 250)
        {
            Console.WriteLine("Total costs: {0:F2}", totalCosts);
            Console.WriteLine("Insufficient area");
        }
        if (mainArea == 250)
        {
            Console.WriteLine("Total costs: {0:F2}", totalCosts);
            Console.WriteLine("No area for beans");
        }
    }
}

