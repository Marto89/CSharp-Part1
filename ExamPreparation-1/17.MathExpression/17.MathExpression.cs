using System;

class MathExpression
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal numerator=(decimal)((n*n)+(decimal)(1/(m*p))+1337M);
        decimal denominator=(n-(128.523123123M*p));
        decimal sin=(Math.Truncate(m%180));
        decimal result = (decimal)((numerator / denominator) + (decimal)Math.Sin((double)sin));

        Console.WriteLine("{0:F6}",result);
    }
}
