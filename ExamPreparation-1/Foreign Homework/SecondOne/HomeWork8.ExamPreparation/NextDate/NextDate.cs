using System;

class NextDate
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime todey = new DateTime(year, month, day);
        todey = todey.AddDays(1);
        string tomorow = todey.ToString("d.M.yyy", System.Globalization.CultureInfo.InvariantCulture);
        Console.WriteLine(tomorow);
    }
}

