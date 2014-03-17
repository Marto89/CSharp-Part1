using System;

class QuatedString
{
    static void Main()
    {
        string way1 = "The \"use\"of quatations causes difficulties.";
        string way2 = @"The ""use"" of quatations causes difficulties.";
        Console.WriteLine(way1);
        Console.WriteLine(way2);
    }
}