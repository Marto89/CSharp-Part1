using System;

class DancingBits
{
    static void Main()
    {
        uint k = uint.Parse(Console.ReadLine());
        uint n = uint.Parse(Console.ReadLine());

        string sum="";
        for (int i = 0; i < n; i++)
        {
            int nN = int.Parse(Console.ReadLine());
            string nConvert = Convert.ToString(nN, 2);
            sum=sum+nConvert;
        }
        uint sum1=0;
        uint sum2=0;
        int counter1=0;
        int counter2=0;
        for (int i = 0; i <sum.Length-1; i++)
        {
            if (sum[i] == '0')
            {
                counter1++;
                counter2 = 0;
                if (counter1 == k && (sum[i+1]) == '1')
                {
                    sum1++;
                }
            }
            if (sum[i] == '1')
            {
                counter2++;
                counter1 = 0;
                if (counter2 == k && (sum[i + 1]) == '0')
                {
                    sum2++;
                }
            }
            if (i == sum.Length - 2)
            {
                if (counter1 == (k - 1) && sum[i + 1] == '0')
                {
                    sum1++;
                }
                if (counter2 == (k - 1) && sum[i + 1] == '1')
                {
                    sum2++;
                }
            }
        }
        sum2 = sum2 + sum1;
        Console.WriteLine(sum2);
    }
}