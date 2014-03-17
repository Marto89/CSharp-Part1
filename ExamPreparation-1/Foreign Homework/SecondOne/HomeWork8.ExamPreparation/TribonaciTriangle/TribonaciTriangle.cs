using System;

class TribonaciTriangle
{
    static void Main()
    {
        Int64 first = Int64.Parse(Console.ReadLine());
        Int64 second = Int64.Parse(Console.ReadLine());
        Int64 third = Int64.Parse(Console.ReadLine());
        Int64 next;
        int l = int.Parse(Console.ReadLine());
        int length = 0;

        for (int i = 1; i <= l; i++)
        {
            length = length + i;
        }

        Int64[] triboaci = new Int64[length];
        triboaci[0] = first;
        triboaci[1] = second;
        triboaci[2] = third;
        for (int i = 3; i < triboaci.Length; i++)
        {
            next = first + second + third;
            triboaci[i] = next;
            first = second;
            second = third;
            third = next;
        }
        int limit = 0;
        for (int i = 1; i <= l; i++)
        {
            for (int g = 0; g < i; g++)
            {
                Console.Write(triboaci[limit]);
                if (limit != triboaci.Length - 1)
                {
                    Console.Write(" ");
                }
                limit++;
            }
            Console.WriteLine();
        }
    }
}

