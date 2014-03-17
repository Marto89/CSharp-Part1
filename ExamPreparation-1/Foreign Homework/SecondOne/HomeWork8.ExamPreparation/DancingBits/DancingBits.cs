using System;

class DancingBits
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        char current;
        char next;
        int count = 1;
        int dancingCount = 0;

        string all = "";
        uint num;

        for (int i = 0; i < n; i++)
        {
            num = uint.Parse(Console.ReadLine());
            all += Convert.ToString(num, 2);
        }

        for (int i = 0; i <= all.Length - 1; )
        {
            current = all[i];
            for (int g = i + 1; g < all.Length; g++)
            {
                next = all[g];
                if (current == next)
                {
                    current = next;
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count == k)
            {
                dancingCount++;
            }
            i = i + count;
            count = 1;
        }
        Console.WriteLine(dancingCount);
    }
}

