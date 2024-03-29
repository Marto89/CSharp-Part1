﻿using System;
using System.Text;

class DrunkenNumbers
{
    static void Main()
    {
        int rounds = int.Parse(Console.ReadLine());
        ulong countMitko = 0;
        ulong countVladko = 0;
        for (int round = 0; round < rounds; round++)
        {
            string drunkenNumber = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < drunkenNumber.Length; i++)
            {
                if (drunkenNumber[i] >= '0' && drunkenNumber[i] <= '9')
                {
                    sb.Append(drunkenNumber[i]);
                }
            }
            drunkenNumber = sb.ToString().TrimStart(new Char[] { '0' });
            int length = drunkenNumber.Length / 2 + drunkenNumber.Length % 2;
            for (int index = 0; index < length; index++)
            {
                if (drunkenNumber[index] >= '0' && drunkenNumber[index] <= '9')
                {
                    countMitko += (ulong)(drunkenNumber[index] - '0');
                }
                if (drunkenNumber[drunkenNumber.Length - 1 - index] >= '0' && drunkenNumber[drunkenNumber.Length - 1 - index] <= '9')
                {
                    countVladko += (ulong)(drunkenNumber[drunkenNumber.Length - 1 - index] - '0');
                }
            }
        }
        if (countMitko > countVladko)
        {
            Console.WriteLine("M {0}", (countMitko - countVladko));
        }
        else if (countMitko < countVladko)
        {
            Console.WriteLine("V {0}", (countVladko - countMitko));
        }
        else
        {
            Console.WriteLine("No {0}", (countMitko + countVladko));
        }
    }
}

