using System;

class DrunkenNumbers
{
    static void Main()
    {
        int  rounds = int.Parse(Console.ReadLine());
   
        int [] drunkenNumbers= new int [rounds];
        int length=0;
        int resultM = 0;
        int resultV = 0;
        int sumM = 0;
        int sumV = 0;
        int finalResult = 0;

        for (int i = 0; i < rounds; i++)
        {
            drunkenNumbers[i] = int.Parse(Console.ReadLine());
            if (drunkenNumbers[i] < 0)
            {
                drunkenNumbers[i] = (drunkenNumbers[i] * (-1));
            }
        }       
       
        for (int i = 0; i < rounds; i++)
        {
            length=drunkenNumbers[i].ToString().Length;
           
             if (length == 9)
            {
                resultM = drunkenNumbers[i] / 10000;
                for (int n = resultM; n > 0; sumM += n % 10, n /= 10) ;
                resultV = drunkenNumbers[i] % 100000;
                for (int n = resultV; n > 0; sumV += n % 10, n /= 10) ;
            }
            else if (length == 8)
            {
                resultM = drunkenNumbers[i] / 10000;
                for (int n = resultM; n > 0; sumM += n % 10, n /= 10) ;
                resultV = drunkenNumbers[i] % 10000;
                for (int n = resultV; n > 0; sumV += n % 10, n /= 10) ;
            }
            else if (length == 7)
            {
                resultM = drunkenNumbers[i] / 1000;
                for (int n = resultM; n > 0; sumM += n % 10, n /= 10) ;
                resultV = drunkenNumbers[i] % 10000;
                for (int n = resultV; n > 0; sumV += n % 10, n /= 10) ;
            }
            else if (length == 6)
            {
                resultM = drunkenNumbers[i] / 1000;
                for (int n = resultM; n > 0; sumM += n % 10, n /= 10) ;
                resultV = drunkenNumbers[i] % 1000;
                for (int n = resultV; n > 0; sumV += n % 10, n /= 10) ;
            }
            else if (length == 5)
            {
                resultM = drunkenNumbers[i] / 100;
                for (int n = resultM; n > 0; sumM += n % 10, n /= 10) ;
                resultV = drunkenNumbers[i] % 1000;
                for (int n = resultV; n > 0; sumV += n % 10, n /= 10) ;
            }
            else if (length == 4)
            {
                resultM = drunkenNumbers[i] / 100;
                for (int n = resultM; n > 0; sumM += n % 10, n /= 10) ;
                resultV = drunkenNumbers[i] % 100;
                for (int n = resultV; n > 0; sumV += n % 10, n /= 10) ;
            }
            else if (length == 3)
            {
                resultM = drunkenNumbers[i] / 10;
                for (int n = resultM; n > 0; sumM += n % 10, n /= 10) ;
                resultV = drunkenNumbers[i] % 100;
                for (int n = resultV; n > 0; sumV += n % 10, n /= 10) ;
            }
            else if (length == 2)
            {
                resultM = drunkenNumbers[i] / 10;
                for (int n = resultM; n > 0; sumM += n % 10, n /= 10) ;
                resultV = drunkenNumbers[i] % 10;
                for (int n = resultV; n > 0; sumV += n % 10, n /= 10) ;
            }
             else if (length == 1)
             {
                 sumM += drunkenNumbers[i];
                 sumV += drunkenNumbers[i];
             }

        }
        if (sumM > sumV)
        {
            finalResult = sumM - sumV;
            Console.WriteLine("M {0} ",finalResult);
        }
        else if (sumM < sumV)
        {
            finalResult = sumV - sumM;
            Console.WriteLine("V {0} ", finalResult);
        }
        else
        {
            finalResult = sumM + sumV;
            Console.WriteLine("No {0} ",finalResult);
        }
    }
}
