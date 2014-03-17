using System;

class Sheets
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());


        int[] sheets =new int[11] { 1024, 512, 256,128, 64, 32, 16, 8,4,2,1  };

        for (int i = 0; i < sheets.Length; i++)
        {
            if (input < sheets[i])
            {
                Console.WriteLine("A"+i);
            }
            else
            {
                input -= sheets[i];
            }

        }


    }
}

