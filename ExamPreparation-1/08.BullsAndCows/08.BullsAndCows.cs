using System;

class Program
{
    static void Main()
    {
        int broi = 0;
        int number = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        int firstSecretNumber = number / 1000;
        int secondSecretNumber = number / 100 % 10;
        int thirdSecretNumber = number / 10 % 10;
        int forthSecretNumber = number % 10;
        for (int i = 1111; i <=9999; i++)
        {
            int firstNumber = i / 1000;
            int secondNumber = i / 100 % 10;
            int thirdNumber = i / 10 % 10;
            int forthNumber = i % 10;

            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0 || forthNumber == 0)
            {
                continue;
            }
            else
            {
                int copyFirstSecretNumber = firstSecretNumber;
                int copySecondSecretNumber = secondSecretNumber;
                int copyThirdSecretNumber = thirdSecretNumber;
                int copyForthSecretNumber = forthSecretNumber;
                int numberOfBulls = 0;
                int numberOfCows = 0;

                if (firstNumber == copyFirstSecretNumber)
                {
                    numberOfBulls++;
                    firstNumber = 0;
                    copyFirstSecretNumber = -1;
                }
                if (secondNumber == copySecondSecretNumber)
                {
                    numberOfBulls++;
                    secondNumber = 0;
                    copySecondSecretNumber = -1;
                }
                if (thirdNumber == copyThirdSecretNumber)
                {
                    numberOfBulls++;
                    thirdNumber = 0;
                    copyThirdSecretNumber = -1;
                }
                if (forthNumber == copyForthSecretNumber)
                {
                    numberOfBulls++;
                    forthNumber = 0;
                    copyForthSecretNumber = -1;

                }
                if (firstNumber == copySecondSecretNumber)
                {
                    numberOfCows++;
                    firstNumber = 0;
                    copySecondSecretNumber = -1;
                }
                if (firstNumber == copyThirdSecretNumber)
                {
                    numberOfCows++;
                    firstNumber = 0;
                    copyThirdSecretNumber = -1;
                }
                if (firstNumber == copyForthSecretNumber)
                {
                    numberOfCows++;
                    firstNumber = 0;
                    copyForthSecretNumber = -1;
                }
                if (secondNumber == copyFirstSecretNumber)
                {
                    numberOfCows++;
                    secondNumber = 0;
                    copyFirstSecretNumber = -1;
                }
                if (secondNumber == copyThirdSecretNumber)
                {
                    numberOfCows++;
                    secondNumber = 0;
                    copyThirdSecretNumber = -1;
                }
                if (secondNumber == copyForthSecretNumber)
                {
                    numberOfCows++;
                    secondNumber = 0;
                    copyForthSecretNumber = -1;
                }
                if (thirdNumber == copySecondSecretNumber)
                {
                    numberOfCows++;
                    thirdNumber = 0;
                    copySecondSecretNumber = -1;
                }
                if (thirdNumber == copyFirstSecretNumber)
                {
                    numberOfCows++;
                    thirdNumber = 0;
                    copyFirstSecretNumber = -1;
                }
                if (thirdNumber == copyForthSecretNumber)
                {
                    numberOfCows++;
                    thirdNumber = 0;
                    copyForthSecretNumber = -1;
                }
                if (forthNumber == copySecondSecretNumber)
                {
                    numberOfCows++;
                    forthNumber = 0;
                    copySecondSecretNumber = -1;
                }
                if (forthNumber == copyThirdSecretNumber)
                {
                    numberOfCows++;
                    forthNumber = 0;
                    copyThirdSecretNumber = -1;
                }
                if (forthNumber == copyFirstSecretNumber)
                {
                    numberOfCows++;
                    forthNumber = 0;
                    copyFirstSecretNumber = -1;
                }
                if (bulls == numberOfBulls && cows == numberOfCows)
                {
                    Console.Write("{0} ", i);
                    broi++;
                }
            }
        }
        if (broi == 0)
        {
            Console.WriteLine("No");
        }
    }
}