using System;

class ExcelColumns
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        char[] elements = new char[lines];


        for (int i = 0; i < lines; i++)
        {
            int letters = char.Parse(Console.ReadLine());
            Console.WriteLine((char)(letters)-64) ;
        }
        
       
        
       

        

    }
}

