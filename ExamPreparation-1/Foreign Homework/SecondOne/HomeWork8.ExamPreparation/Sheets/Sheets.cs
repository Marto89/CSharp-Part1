using System;

class Sheets
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] sheets = { "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10" };

        string needToCyt = Convert.ToString(n, 2).PadLeft(11, '0');

        for (int i = 0; i < needToCyt.Length; i++)
        {
            if (needToCyt[i] == '0')
            {
                Console.WriteLine(sheets[i]);
            }
        }
    }
}

