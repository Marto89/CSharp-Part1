using System;

class BinaryDigitsCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int counter1 = 0;
            int counter2 = 0;
            uint nN = uint.Parse(Console.ReadLine());
            string converted = Convert.ToString(nN,2);

            foreach (char j in converted)
            {
                if (j == '0')
                {
                    counter1++;
                }
                if (j == '1')
                {
                    counter2++;
                }
            }
            if (b == 0)
            {
                Console.WriteLine(counter1);
            }
            if (b == 1)
            {
                Console.WriteLine(counter2);
            }
        }
    }
}
