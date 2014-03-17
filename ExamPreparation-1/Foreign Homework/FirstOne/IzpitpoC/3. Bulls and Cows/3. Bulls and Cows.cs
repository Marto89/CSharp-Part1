using System;
using System.Numerics;

class BullsAndCows
{
    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        
        if (bulls + cows <= 4)
        {
            
            int countSolution = 0;
            for (int i = 1111; i <= 9999; i++)
            {
                int countCows = 0;
                int countBulls = 0;
                int firstDigit = secretNumber / 1000;
                int secondDigit = (secretNumber / 100) % 10;
                int thirdDigit = (secretNumber / 10) % 10;
                int fourthDigit = secretNumber % 10;


                int one = i / 1000;
                int two = (i / 100) % 10;
                int three = (i / 10) % 10;
                int four = i % 10;

                if (two == 0 || three == 0 || four == 0)
                {
                    continue;
                }

                if (one == firstDigit)
                {
                    one = 0;
                    countBulls++;
                    firstDigit = -1;
                }

                if (two == secondDigit)
                {
                    two = 0;
                    countBulls++;
                    secondDigit = -1;
                }

                if (three == thirdDigit)
                {
                    three = 0;
                    countBulls++;
                    thirdDigit = -1;
                }

                if (four == fourthDigit)
                {
                    four = 0;
                    countBulls++;
                    fourthDigit = - 1;
                }

                 if (one == secondDigit)
                {
                    one = 0;
                    countCows++;
                    secondDigit = -1;
                }

                else if (one == thirdDigit)
                {
                    one = 0;
                    countCows++;
                    thirdDigit = -1;
                }

                else if (one == fourthDigit)
                {
                    one = 0;
                    countCows++;
                    fourthDigit = -1;
                }

                 if (two == firstDigit)
                {
                    two = 0;
                    countCows++;
                    firstDigit = -1;
                }

                else if (two == thirdDigit)
                {
                    two = 0;
                    countCows++;
                    thirdDigit = -1;
                }

                else if (two == fourthDigit)
                {
                    two = 0;
                    countCows++;
                    fourthDigit = -1;
                }

                 if (three == firstDigit)
                {
                    three = 0;
                    countCows++;
                    firstDigit = -1;
                }


                else if (three == secondDigit)
                {
                    three = 0;
                    countCows++;
                    secondDigit = - 1;
                }

                else if (three == fourthDigit)
                {
                    three = 0;
                    countCows++;
                    fourthDigit = -1;
                }

                if (four == firstDigit)
                {
                    fourthDigit = 0;
                    countCows++;
                    firstDigit = - 1;
                }
                else if (four == secondDigit)
                {
                    fourthDigit = 0;
                    countCows++;
                    secondDigit =- 1;
                }
                else if (four == thirdDigit)
                {
                    fourthDigit = 0;
                    countCows++;
                    thirdDigit = -1;
                }
                if (countBulls == bulls && countCows == cows)
                {
                    Console.Write(i + " ");
                    countSolution++;
                }
               
            }
            if (countSolution == 0)
            {
                Console.WriteLine("No");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

