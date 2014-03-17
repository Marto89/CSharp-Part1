using System;

class Pillars
{
    static void Main()
    {
        string[] grid = new string[8];
        int num;

        for (int i = 0; i < 8; i++)
        {
            num = int.Parse(Console.ReadLine());
            grid[i] = Convert.ToString(num, 2).PadLeft(8, '0');
        }

        int countLeft = 0;
        int countRight = 0;
        int pillarIndex = 0;
        int count = 0;
        bool isPossible = false;

        for (int pillar = 0; pillar < 8; pillar++)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int g = 0; g < pillar; g++)
                {
                    if (grid[i][g] == '1')
                    {
                        countLeft++;
                    }
                }

                for (int f = pillar + 1; f < 8; f++)
                {
                    if (grid[i][f] == '1')
                    {
                        countRight++;
                    }
                }
            }

            if (countLeft == countRight)
            {
                isPossible = true;
                if (Math.Abs(pillar - 7) > pillarIndex)
                {
                    pillarIndex = Math.Abs(pillar - 7);
                    count = countLeft;
                }
            }

            countLeft = 0;
            countRight = 0;
        }

        if (isPossible)
        {
            Console.WriteLine(pillarIndex);
            Console.WriteLine(count);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

