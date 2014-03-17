using System;
using System.Text;

class ASCIITable
{
    static void Main()
    {
        Console.Title = (" 12.ASCIITable");
        for (int c = 0; c < 127; c++) 
        {
            Console.WriteLine("Character:{0}={1}", c, (char)c);
        }
    }
}
