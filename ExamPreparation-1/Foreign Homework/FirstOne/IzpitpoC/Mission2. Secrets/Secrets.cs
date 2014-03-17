using System;

class KidsAcademy
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            Console.Write(new string('.', i - 1));
            Console.Write(new string('*',1));
            Console.Write(new string('.',n-i));
            Console.WriteLine();
        }
        Console.Write(new string('.', n - 1));
        Console.Write(new string('*', 1));
        Console.WriteLine();
        for (int i = n - 1; i > 0; i--)
        {
            Console.Write(new string('.', i - 1));
            Console.Write(new string('*',1));
            Console.Write(new string('.',n-i));
            Console.WriteLine();
        }
    }
}

