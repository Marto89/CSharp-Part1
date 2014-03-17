using System;

class Anacci
{
    static void Main(string[] args)
    {
        int firstElement = char.Parse(Console.ReadLine()) - 64;
        int secondElement = char.Parse(Console.ReadLine()) - 64;
        int lines = int.Parse(Console.ReadLine());

        if (lines < 0)
        {
            lines = lines * (-1);
        }

        if (lines == 1)
        {
            Console.WriteLine((char)(firstElement + 64)); return;
        }

        int[] allElements = new int[lines * 2 - 1];
        allElements[0] = firstElement;
        allElements[1] = secondElement;
        int nextElement;


        for (int i = 2; i < lines * 2 - 1; i++)
        {

            nextElement = (firstElement + secondElement) % 26;
            if (nextElement == 0)
            {
                nextElement = 26;
            }
            firstElement = secondElement;
            secondElement = nextElement;
            allElements[i] = nextElement;
        }


        Console.WriteLine((char)(allElements[0] + 64));
        Console.Write((char)(allElements[1] + 64));
        Console.Write((char)(allElements[2] + 64));
        Console.WriteLine();

        int count = 3;
        int counter = 0;
        for (int i = 3; i <= lines; i++)
        {

            counter++;
            for (int j = 0; j < 2; j++)
            {

                Console.Write((char)(allElements[count] + 64));

                count++;
                if (j < 1)
                {
                    for (int h = 0; h < counter; h++)
                    {
                        Console.Write(" ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}

