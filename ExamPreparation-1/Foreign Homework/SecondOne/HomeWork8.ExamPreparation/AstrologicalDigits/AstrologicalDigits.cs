using System;

class AstrologicalDigits
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int sum = 0;
        int digit;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != '-' && input[i] != '.')
            {
                digit = int.Parse(input[i].ToString());
                sum = sum + digit;
            }
            if (sum > 9 && i == input.Length - 1)
            {
                input = sum.ToString();
                sum = 0;
                i = -1;
            }
        }
        Console.WriteLine(sum);
    }
}

