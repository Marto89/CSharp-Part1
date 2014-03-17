using System;

class Trapezoid
{
    static void Main()
    {
        int widhtTopN = int.Parse(Console.ReadLine());
        int widhtBottomN = 2 * widhtTopN;
        
        
        string topBorder = new string ('.',widhtTopN);
        string topStars = new string ('*',widhtTopN);
        Console.Write(topBorder);
        Console.WriteLine(topStars);
        int divider = widhtTopN - 1;

        for (int i = divider,j=divider; i > 0; i--,j++)
			{
                string left = new string('.',i);
                string right = new string('.', j);
                Console.WriteLine(left + "*" + right + "*");
			}
        string bottom = new string('*', widhtBottomN);
        Console.WriteLine(bottom);

        
    }
}

