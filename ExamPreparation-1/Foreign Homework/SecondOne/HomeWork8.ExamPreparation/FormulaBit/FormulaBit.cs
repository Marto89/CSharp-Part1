using System;

class FormulaBit
{
    static void Main()
    {
        string[] grid = new string[8];
        int num;

        for (int i = 0; i < grid.Length; i++)
        {
            num = int.Parse(Console.ReadLine());
            grid[i] = Convert.ToString(num, 2).PadLeft(8, '0');
        }

        bool mooveSouth = (grid[0][7] == '0');
        bool mooveWest = false;
        bool mooveNorth = false;
        bool posible = false;
        int oldG = -1;

        int turns = 0;
        int cells = 0;

        for (int i = 0; i < 8;)
        {
            for (int g = 7; g >= 0;)
            {
                if (mooveSouth)
                {
                    i++;
                    cells++;
                    if (i == 7 && grid[i][g] == '0')
                    {
                        if (g == 0)
                        {
                            posible = true;
                        }
                        else
                        {
                            mooveSouth = false;
                            mooveWest = true;
                            turns++;
                        }
                    }
                    if (grid[i][g] == '1')
                    {
                        mooveSouth = false;
                        mooveWest = true;
                        turns++;
                        i--;
                        cells--;
                    }
                }
                if (mooveWest)
                {
                    g--;
                    cells++;
                    if (g == 0 && grid[i][g] == '0')
                    {
                        if (i == 7)
                        {
                            posible = true;
                        }
                        else
                        {
                            mooveWest = false;
                            mooveNorth = true;
                            turns++;
                        }
                    }
                    if (grid[i][g] == '1')
                    {
                        mooveWest = false;
                        mooveNorth = true;
                        turns++;
                        g++;
                        cells--;
                    }
                }
                if (mooveNorth)
                {
                    i--;
                    cells++;
                    if (i == 0 && grid[i][g] == '0')
                    {
                        mooveNorth = false;
                        mooveSouth = true;
                        turns++;
                    }
                    if (grid[i][g] == '1')
                    {
                        oldG = g;
                        mooveNorth = false;
                        mooveSouth = true;
                        turns++;
                        cells--;
                        i++;
                    }
                }
            }
        }
        if (posible)
        {
            Console.WriteLine("{0} {1}", cells, turns);
        }
        else
        {
            Console.WriteLine("No {0}", cells);
        }
    }
}

