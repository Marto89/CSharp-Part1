using System;

class CountLines
{
    static void Main(string[] args)
    {
        int num;
        int mask;
        int count = 1;
        int maxcount = 0;
        int[] grid = new int[8];
        for (int i = 0; i < 8; i++)
        {
            num = int.Parse(Console.ReadLine());
            grid[i] = num;
        }
        mask = grid[0];
        for (int i = 1; i < 8; i++)
        {
            mask = mask & grid[i];
            if (mask!=0)
            {
                count++;
                if (count >= maxcount)
                {
                    maxcount = count;
                }
            }
            else
            {
                mask = grid[i];
                count = 1;
            }
            
            Console.WriteLine(Convert.ToString(mask,2));
        }
        if (count >= maxcount)
        {
            maxcount = count;
        }
        Console.WriteLine(maxcount);
    }
}

