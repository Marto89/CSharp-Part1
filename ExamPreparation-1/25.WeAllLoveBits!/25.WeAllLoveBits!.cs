using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <n; i++)
        {
            int nN = int.Parse(Console.ReadLine());

            string convert = Convert.ToString(nN, 2);

            int counter = 0;
            string sum = "";
            for (int j = 1; j <= convert.Length; j++)
            {
                switch (convert[convert.Length - j])
                {
                    case '1':
                        counter = 1;
                        sum += 1;
                        break;
                    case '0':
                        if (counter == 1)
                        {
                            sum += 0;
                        }
                        break;
                }
            }
            Console.WriteLine(Convert.ToInt32(sum, 2));
        }
    }
}
