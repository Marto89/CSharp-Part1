using System;

class ThreeSixNine
{
    static void Main()
    {
        checked
        {
            decimal a = decimal.Parse(Console.ReadLine());
            if (a < 0)
            {
                a = a * (-1);
            }
            decimal b = decimal.Parse(Console.ReadLine());
            if (b < 0)
            {
                b = b * (-1);
            }
            decimal c = decimal.Parse(Console.ReadLine());
            if (c < 0)
            {
                c = c * (-1);
            }
            
            decimal sum = 0;
            decimal finalResult = 0;
            if (b == 3)
            {
                sum = a + c;
                if (sum % 3M == 0)
                {
                    finalResult = sum / 3M;
                    Console.WriteLine(finalResult);
                    Console.WriteLine(sum);
                }
                else
                {
                    finalResult = sum % 3M;
                    Console.WriteLine(finalResult);
                    Console.WriteLine(sum);
                }
            }
            if (b == 6)
            {
                sum = a * c;
                if (sum % 3M == 0)
                {
                    finalResult = sum / 3M;
                    Console.WriteLine(finalResult);
                    Console.WriteLine(sum);
                }
                else
                {
                    finalResult = sum % 3M;
                    Console.WriteLine(finalResult);
                    Console.WriteLine(sum);
                }
            }
            if (b == 9)
            {
                sum = a % c;
                if (sum % 3M == 0)
                {
                    finalResult = sum / 3M;
                    Console.WriteLine(finalResult);
                    Console.WriteLine(sum);
                }
                else
                {
                    finalResult = sum % 3M;
                    Console.WriteLine(finalResult);
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
