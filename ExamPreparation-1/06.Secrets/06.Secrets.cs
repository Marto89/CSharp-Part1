using System;
using System.Collections.Generic;
using System.Numerics;

class Secrets
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        if (n < 0)
        {
            n = n * (-1);
        }

        BigInteger number = n;
        BigInteger length = n.ToString().Length;
        BigInteger digitPosition=0;
        BigInteger specialSum=0;
        BigInteger lengthSequence=0;
        int startPosition = 0;

        for (BigInteger i = 1; i <= length; i++ )
       {
           digitPosition = (BigInteger)(number % 10);
            number /= 10;

           if (i%2!=0)
           {           
                specialSum+=(BigInteger)(digitPosition*(i*i));
           }
           if (i % 2 == 0)
           {              
               specialSum += ((BigInteger)(digitPosition* digitPosition) * i);
           }
       
       }
        char[] englishAlphabet = new char[52] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        
        lengthSequence = specialSum % 10;

        Console.WriteLine(specialSum);
        if (lengthSequence != 0)
        {
            if (specialSum > 26)
            {
                startPosition = (int)(specialSum%26);

                for (BigInteger i = 0; i < lengthSequence; i++)
                {                   
                    Console.Write(englishAlphabet[startPosition]);
                    startPosition++;
                }
            }
            else if (specialSum < 26)
            {
                startPosition = (int)(specialSum%26);
                for (BigInteger i = 0; i < lengthSequence; i++)
                {
                    Console.Write(englishAlphabet[startPosition]);
                    startPosition++;
                }
            }
            else
            {
                for (int i = 0; i < lengthSequence; i++)
                {
                    Console.Write(englishAlphabet[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("{0} has no secret alpha-sequence",n);
        }
        Console.WriteLine();
    }
}
