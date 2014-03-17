using System;

    class FighterAttack
{
    static void Main()
    {
        int [] plantXCoords=new int [2];
        int []  plantYCoords=new int [2];
        int [] fighterCoords = new int[2];
        int[] missleXCoords = new int[4];
        int[] missleYCoords = new int[4];
        int plantLeft, plantRight, plantTop, plantBottom, distance, i;
        ushort damage;

        for (i = 0; i < 2; i++)
        {
          plantXCoords[i] = int.Parse(Console.ReadLine());
          plantYCoords[i] = int.Parse(Console.ReadLine());
        }
        for (i = 0; i < 2; i++)
        {
          fighterCoords[i] = int.Parse(Console.ReadLine()); 
        }
         distance = int.Parse(Console.ReadLine());

         plantLeft = Math.Min(plantXCoords[0], plantXCoords[1]);
         plantRight = Math.Max(plantXCoords[0],plantXCoords[1]);
         plantBottom = Math.Min(plantYCoords[0],plantYCoords[1]);
         plantTop = Math.Max(plantYCoords[0],plantYCoords[1]);

         missleXCoords[0] = fighterCoords[0] + distance;
         missleYCoords[0] = fighterCoords[1];

         missleXCoords[1]=fighterCoords[0]+distance+1;
         missleYCoords[1] = fighterCoords[1];

         missleXCoords[2]=fighterCoords[0]+distance;
         missleYCoords[2] = fighterCoords[1] + 1;

         missleXCoords[3] = fighterCoords[0] + distance;
         missleYCoords[3] = fighterCoords[1] - 1;

         for ( i = 0, damage=0; i <=3; i++)
         {
             if (missleXCoords[i] >= plantLeft && missleXCoords[i] <= plantRight && missleYCoords[i] >= plantBottom && missleYCoords[i] <= plantTop)
             {
                if(i==0)
                {
                    damage += 100;
                }
                else if (i == 2 || i==3)
                {
                    damage += 50;
                }
                else
                {
                    damage += 75;
                }
             }
         }
         Console.WriteLine("{0}%",damage);
    }
}
