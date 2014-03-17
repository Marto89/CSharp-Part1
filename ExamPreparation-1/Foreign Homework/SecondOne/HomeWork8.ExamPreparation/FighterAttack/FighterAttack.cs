using System;

class FighterAttack
{
    static void Main(string[] args)
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());
        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        bool inside;
        int missle = fx + d;
        int score = 0;

        if (px1 > px2)
        {
            if (py1 > py2)
            {
                inside = (missle <= px1 && missle >= px2 && fy <= py1 && fy >= py2);
                if (inside)
                {
                    score += 100;
                }
                inside = (missle + 1 <= px1 && missle + 1 >= px2 && fy <= py1 && fy >= py2);
                if (inside)
                {
                    score += 75;
                }
                inside = (missle <= px1 && missle >= px2 && fy + 1 <= py1 && fy + 1 >= py2);
                if (inside)
                {
                    score += 50;
                }
                inside = (missle <= px1 && missle >= px2 && fy - 1 <= py1 && fy - 1 >= py2);
                if (inside)
                {
                    score += 50;
                }
            }
            else
            {
                inside = (missle <= px1 && missle >= px2 && fy >= py1 && fy <= py2);
                if (inside)
                {
                    score += 100;
                }
                inside = (missle + 1 <= px1 && missle + 1 >= px2 && fy >= py1 && fy <= py2);
                if (inside)
                {
                    score += 75;
                }
                inside = (missle <= px1 && missle >= px2 && fy + 1 >= py1 && fy + 1 <= py2);
                if (inside)
                {
                    score += 50;
                }
                inside = (missle <= px1 && missle >= px2 && fy - 1 >= py1 && fy - 1 <= py2);
                if (inside)
                {
                    score += 50;
                }
            }
        }
        else
        {
            if (py1 > py2)
            {
                inside = (missle >= px1 && missle <= px2 && fy <= py1 && fy >= py2);
                if (inside)
                {
                    score += 100;
                }
                inside = (missle + 1 >= px1 && missle + 1 <= px2 && fy <= py1 && fy >= py2);
                if (inside)
                {
                    score += 75;
                }
                inside = (missle >= px1 && missle <= px2 && fy + 1 <= py1 && fy + 1 >= py2);
                if (inside)
                {
                    score += 50;
                }
                inside = (missle >= px1 && missle <= px2 && fy - 1 <= py1 && fy - 1 >= py2);
                if (inside)
                {
                    score += 50;
                }
            }
            else
            {
                inside = (missle >= px1 && missle <= px2 && fy >= py1 && fy <= py2);
                if (inside)
                {
                    score += 100;
                }
                inside = (missle + 1 >= px1 && missle + 1 <= px2 && fy >= py1 && fy <= py2);
                if (inside)
                {
                    score += 75;
                }
                inside = (missle >= px1 && missle <= px2 && fy + 1 >= py1 && fy + 1 <= py2);
                if (inside)
                {
                    score += 50;
                }
                inside = (missle >= px1 && missle <= px2 && fy - 1 >= py1 && fy - 1 <= py2);
                if (inside)
                {
                    score += 50;
                }
            }
        }
        Console.WriteLine(score + "%");
    }
}

