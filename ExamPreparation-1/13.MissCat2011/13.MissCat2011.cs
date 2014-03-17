using System;

class MissCat2011
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int max=0;
        int cat1=0;
        int cat2=0;
        int cat3=0;
        int cat4=0;
        int cat5=0;
        int cat6=0;
        int cat7=0;
        int cat8=0;
        int cat9=0;
        int cat10=0;
        int winnercat=0;

        for (int i = 1; i <= n; i++)
        {
           int catNumber = int.Parse(Console.ReadLine());

            switch (catNumber)
            {
                case 1:
                    cat1++;
                    break;
                case 2: 
                    cat2++;
                    break;
                case 3:
                    cat3++;
                    break;
                case 4:
                    cat4++;
                    break;
                case 5: 
                    cat5++;
                    break;
                case 6: 
                    cat6++;
                    break;
                case 7: 
                    cat7++;
                    break;
                case 8: 
                    cat8++;
                    break;
                case 9: 
                    cat9++;
                    break;
                case 10:
                    cat10++;
                    break;
            }            
        }

        if (cat1 >= cat2)
        {
            max = cat1;
            winnercat=1;
        }
        else
        {
            max=cat2;
            winnercat=2;
        }
         if (max < cat3)
        {
            max = cat3;
            winnercat = 3;
        }
         if (max < cat4)
         {
             max = cat4;
             winnercat = 4;
         } 
         if (max < cat5)
         {
             max = cat5;
             winnercat = 5;
         }
         if (max < cat6)
         {
             max = cat6;
             winnercat = 6;
         } 
        if (max < cat7)
         {
             max = cat7;
             winnercat = 7;
         }
         if (max < cat8)
         {
             max = cat8;
             winnercat = 8;
         }
         if (max < cat9)
         {
             max = cat9;
             winnercat = 9;
         }
         if (max < cat10)
         {
             max = cat10;
             winnercat = 10;
         }
         Console.WriteLine(winnercat);
    }
}
