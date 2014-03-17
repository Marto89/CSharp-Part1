using System;

class TheHorror
{
    static void Main()
    {
        checked
        {
            string number = Console.ReadLine();
            string sum = "";
            int counter = 0;
            int counter2 = 0;
            if (number[0] == '-')
            {
                counter++;
            }
            for (int i = counter; i < number.Length; i++)
            {

                if (i % 2 == 0 && (number[i]=='0' || number[i]=='1' || number[i]=='2' || number[i]=='3' || number[i]=='4' || number[i]=='5' || number[i]=='6' || number[i]=='7' || number[i]=='8' || number[i]=='8' || number[i]=='9'))
                {
                    sum += number[i];
                    counter2++;
                }
            }

            int realSum = 0;
            for (int i = counter; i < sum.Length; i++)
            {
                realSum += sum[i] - 48;
            }
            Console.WriteLine("{0} {1}", counter2, realSum);
        }
    }
}