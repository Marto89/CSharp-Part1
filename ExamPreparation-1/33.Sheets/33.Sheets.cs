using System;

class Sheets
{
    static void Main()
    {
        int nPieces = int.Parse(Console.ReadLine());
        int nPiecesUse ;
        int mask = 1;
        int a0=0,a1=0,a2=0,a3=0,a4=0,a5=0,a6=0,a7=0,a8=0,a9=0,a10=0;

        for (int i = 0; i <=10; i++)
        {
            mask = 1;
            nPiecesUse = nPieces;
            mask = mask << i;
            int result=nPiecesUse & mask;
            result = result >> i;
            if (result == 1)
            {
                switch (i)
                {
                    case 10:
                        a0 = 1;
                        break;
                    case 9:
                        a1 = 1;
                        break;
                    case 8:
                        a2 = 1;
                        break;
                    case 7:
                        a3 = 1;
                        break;
                    case 6:
                        a4 = 1;
                        break;
                    case 5:
                        a5 = 1;
                        break;
                    case 4:
                        a6 = 1;
                        break;
                    case 3:
                        a7 = 1;
                        break;
                    case 2:
                        a8 = 1;
                        break;
                    case 1:
                        a9 = 1;
                        break;
                    case 0:
                        a10 = 1;
                        break;
                }
            }
        }
        if (a0 == 0)
        {
            Console.WriteLine("A0");
        }
        if (a1 == 0)
        {
            Console.WriteLine("A1");
        }
        if (a2 == 0)
        {
            Console.WriteLine("A2");
        }
        if (a3 == 0)
        {
            Console.WriteLine("A3");
        }
        if (a4 == 0)
        {
            Console.WriteLine("A4");
        }
        if (a5 == 0)
        {
            Console.WriteLine("A5");
        }
        if (a6 == 0)
        {
            Console.WriteLine("A6");
        }
        if (a7 == 0)
        {
            Console.WriteLine("A7");
        }
        if (a8 == 0)
        {
            Console.WriteLine("A8");
        }
        if (a9 == 0)
        {
            Console.WriteLine("A9");
        }
        if (a10 == 0)
        {
            Console.WriteLine("A10");
        }
    }
}
