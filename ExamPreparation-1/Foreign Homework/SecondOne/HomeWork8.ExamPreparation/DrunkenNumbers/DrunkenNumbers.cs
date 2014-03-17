using System;

class DrunkenNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int round;
        int digit = 0;
        int limit = 0;
        string roundString;
        int mBeers = 0;
        int vBeers = 0;
        int g;

        for (int i = 0; i < n; i++)
        {
            roundString = Console.ReadLine();
            roundString = roundString.Replace("-", "");
            if (roundString.Length > 9)
            {
                roundString = roundString.Substring(0, 9);
            }
            round = int.Parse(roundString);
            roundString = round.ToString();

            if (roundString.Length % 2 == 0)
            {
                limit = 0;
            }
            else
            {
                limit = 1;
            }

            g = ((roundString.Length > 9) ? 9 : roundString.Length - 1);
            digit = round % 10;
            while (g >= 0)
            {
                if (g < (roundString.Length + limit)/2)
                {
                    mBeers += digit;
                }
                if (g >= (roundString.Length)/2)
                {
                    vBeers += digit;
                }

                round = round / 10;
                digit = round % 10;
                g--;
            }
        }
        if (mBeers == vBeers)
        {
            Console.WriteLine("No " + (mBeers + vBeers));
        }
        else
        {
            Console.WriteLine("{0} {1}", (mBeers > vBeers ? "M" : "V"), Math.Abs(mBeers - vBeers));
        }
    }
}

