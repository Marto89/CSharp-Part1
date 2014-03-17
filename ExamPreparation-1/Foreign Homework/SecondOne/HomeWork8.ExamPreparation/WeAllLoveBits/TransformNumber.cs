using System;

class TransformNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int num;
        string oldNum;
        string newNum = "";
        int transformed;
        int[] newNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            num = int.Parse(Console.ReadLine());
            oldNum = Convert.ToString(num, 2);
            for (int g = oldNum.Length -1 ; g >= 0; g--)
            {
                newNum = newNum + oldNum[g];
            }
            transformed = Convert.ToInt32(newNum, 2);
            newNumbers[i] = transformed;
            newNum = "";
        }

        for (int i = 0; i < newNumbers.Length; i++)
        {
            Console.WriteLine(newNumbers[i]);
        }
    }
}

