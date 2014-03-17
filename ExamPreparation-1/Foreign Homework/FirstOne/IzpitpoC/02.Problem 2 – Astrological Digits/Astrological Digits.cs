using System;

class AstrologicalDigits
{
    static void Main()
    {
        string numberN = Console.ReadLine();

        int sumOfNumberN = 0;

        for (int i = 0; i < numberN.Length; i++)
        {
            if (numberN[i] != '.' && numberN[i] != '-')
            {
                sumOfNumberN += int.Parse(numberN[i].ToString());
            }
        }
        int newSum = sumOfNumberN;

        while (sumOfNumberN > 9)
        {
            newSum = sumOfNumberN;
            sumOfNumberN = 0;
            do
            {
                int currentDigit = newSum % 10;
                newSum /= 10;
                sumOfNumberN += currentDigit;
            }
            while (newSum != 0);
        }
        Console.WriteLine(sumOfNumberN);
    }
}

