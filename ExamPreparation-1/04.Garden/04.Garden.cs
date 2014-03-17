using System;

class Garden
{
    static void Main()
    {
        decimal tomatoSeeds = decimal.Parse(Console.ReadLine());
        ushort tomatoArea = ushort.Parse(Console.ReadLine());

        decimal cucumberSeeds = decimal.Parse(Console.ReadLine());
        ushort cucumberArea = ushort.Parse(Console.ReadLine());

        decimal potatoSeeds = decimal.Parse(Console.ReadLine());
        ushort potatoArea = ushort.Parse(Console.ReadLine());

        decimal carrotSeeds = decimal.Parse(Console.ReadLine());
        ushort carrotArea = ushort.Parse(Console.ReadLine());

        decimal cabbageSeeds = decimal.Parse(Console.ReadLine());
        ushort cabbageArea = ushort.Parse(Console.ReadLine());

        decimal beansSeeds = decimal.Parse(Console.ReadLine());

        ushort beansArea = 0;

        ushort totalArea = (ushort)(tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);
        decimal totalCosts = (decimal)(tomatoSeeds*0.5m + cucumberSeeds*0.4m + potatoSeeds*0.25m + carrotSeeds*0.6m + cabbageSeeds*0.3m + beansSeeds*0.4m);

        Console.WriteLine("Total costs: {0:F2}", totalCosts);

        if (totalArea < 250)
        {
            beansArea = (ushort)(250 - totalArea);
            Console.WriteLine("Beans area: {0}",beansArea);
        }
        else if (totalArea == 250)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Insufficient area");
        }
    }
}
