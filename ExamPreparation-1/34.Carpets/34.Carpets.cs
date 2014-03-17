using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char point = '.';
        char slash = '/';
        char backslash = '\\';

        for (int i = 1; i <=n/2; i++)
        {
            Console.Write(new string(point,n/2-i));
           
            for (int j = 0; j <i ; j++)
            {               
                if (j==0 || j%2==0 )
                {
                    Console.Write(slash);
                }
                else
                {
                   Console.Write(" ");                   
                }   
                
            }
            for (int j = i-1; j >= 0; j--)
            {
                if (j == 0 || j%2==0)
                {
                    Console.Write(backslash);
                }
                else 
                {
                    Console.Write(" ");
                }


            }
            Console.Write(new string(point, n / 2 - i));
            Console.WriteLine();
        }

        for (int i = n/2; i >= 1; i--)
        {
            Console.Write(new string(point, n / 2 - i));

            for (int j = 0; j < i; j++)
            {
                if (j == 0 || j % 2 == 0)
                {
                    Console.Write(backslash);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            for (int j = i - 1; j >= 0; j--)
            {
                if (j == 0 || j % 2 == 0)
                {
                    Console.Write(slash);
                }
                else
                {
                    Console.Write(" ");
                }


            }
            Console.Write(new string(point, n / 2 - i));
            Console.WriteLine();
        }  
    }
}
