using System;
class MathExpression
{
    static void Main()
    {
        double numberN = double.Parse(Console.ReadLine());
        double numberM = double.Parse(Console.ReadLine());
        double numberP = double.Parse(Console.ReadLine());

        double chislitel = Math.Pow(numberN, 2) + 1 / (numberM * numberP) + 1337;
        double znamenatel = numberN - (128.523123123 * numberP);
        double sin =Math.Sin((int)numberM % 180);
        
        Console.WriteLine("{0:f6}", (chislitel / znamenatel) + sin);
    }                              
}

