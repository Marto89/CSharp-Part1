using System;

class NullVariable
{
    static void Main()
    {
        Console.Title = ("13.NullVariable");
        int? a = null;
        double? b = null;

        Console.WriteLine("Printing the nullable variables: a: {0} b: {1}", a, b);

        a += null;
        b += 3.1415926;
        Console.WriteLine("Printing the nullable variables: a: {0} b: {1}", a, b);
    }
}
