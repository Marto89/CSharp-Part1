using System;

class ShipDamage
{
    static void Main()
    {
        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());

        int left = Math.Min(sx1, sx2);
        int right = Math.Max(sx1, sx2);
        int bot = Math.Min(sy1, sy2);
        int top = Math.Max(sy1, sy2);

        int horrizon = int.Parse(Console.ReadLine());

        int[,] gun = new int[3,2];

        for (int g = 0; g < 3; g++)
        {
            for (int i = 0; i < 2; i++)
            {
                gun[g,i] = int.Parse(Console.ReadLine());
            }
        }

        int range;
        int score = 0;
        for (int i = 0; i < 3; i++)
        {
            range = 2 * (horrizon - gun[i,1]);
            gun[i, 1] = gun[i, 1] + range;

            if (gun[i,0] > left && gun[i,0] < right && gun[i,1] > bot && gun[i,1] < top)
            {
                score += 100;
            }
            if ((gun[i,0] == left || gun[i,0] == right) && (gun[i,1] == bot || gun[i,1] == top))
            {
                score += 25;
            }
            if ((gun[i,0] < right && gun[i,0] > left) && (gun[i,1] == top || gun[i,1] == bot))
            {
                score += 50;
            }
            if ((gun[i, 1] < top && gun[i, 1] > bot) && (gun[i, 0] == right || gun[i, 1] == left))
            {
                score += 50;
            }
        }
        Console.WriteLine(score + "%");
    }
}

