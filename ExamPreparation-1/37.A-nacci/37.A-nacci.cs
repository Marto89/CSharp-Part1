using System;

class aNnacci
{
    static void Main()
    {
            int firstElement = char.Parse(Console.ReadLine()) - 64;
            int secondElement = char.Parse(Console.ReadLine()) - 64;
            int numberLines = int.Parse(Console.ReadLine());
            if (numberLines < 0)
            {
                numberLines = numberLines * (-1);
            }
            int thirdElement;
            int[] allElements = new int[numberLines * 2 - 1];
            allElements[0] = firstElement;

            if (numberLines == 1)
            {
                Console.WriteLine((char)(allElements[0] + 64)); return;
            }

            allElements[1] = secondElement;

            for (int i = 2; i < numberLines * 2 - 1; i++)
            {
                thirdElement = (firstElement + secondElement) % 26;
                if (thirdElement == 0)
                {
                    thirdElement=26;
                }
                firstElement = secondElement;
                secondElement = thirdElement;
                allElements[i] = thirdElement;
            }


            Console.WriteLine((char)(allElements[0] + 64));
            Console.Write((char)(allElements[1] + 64));
            Console.WriteLine((char)(allElements[2] + 64));

            int indicator = 2;
            int indicator2 = 0;
            for (int rows = 3; rows <= numberLines; rows++)
            {
                for (int columns = 0; columns < 1; columns++)
                {
                    indicator++;
                    Console.Write((char)(allElements[indicator] + 64));
                    indicator++;
                    indicator2++;
                    for (int whiteSpace = 0; whiteSpace < indicator2; whiteSpace++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine((char)(allElements[indicator] + 64));
                }
            }        
    }  
}
