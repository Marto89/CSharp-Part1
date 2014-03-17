using System;

class KidsAcademy
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        char asteriks='*';
        char numberSign='#';

        Console.WriteLine("{0,3}{1}{2}",numberSign,asteriks,numberSign);
        Console.WriteLine("{0,3}{1}{2}",asteriks,asteriks,asteriks);
        Console.WriteLine("{0,3}{1}{2}", numberSign, asteriks, numberSign);
        Console.WriteLine("{0,4}",b);
        Console.Write("{0}",a);
        Console.Write("{0,3}", b);
        Console.WriteLine("{0,3}",a);
        Console.Write("{0,2}",a);
        Console.Write("{0,2}",b);
        Console.WriteLine("{0,2}",a);
        Console.WriteLine("{0,3}{1}{2}",a,b,a);

    }
}