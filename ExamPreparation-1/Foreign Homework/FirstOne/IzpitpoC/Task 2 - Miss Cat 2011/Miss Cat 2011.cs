﻿using System;

class MissCat2011
{
    static void Main()
    {
        int juriN = int.Parse(Console.ReadLine());

        int cat1 = 0;
        int cat2 = 0;
        int cat3 = 0;
        int cat4 = 0;
        int cat5 = 0;
        int cat6 = 0;
        int cat7 = 0;
        int cat8 = 0;
        int cat9 = 0;
        int cat10 = 0;

        for (int i = 0; i < juriN; i++)
        {
            byte juriVote = byte.Parse(Console.ReadLine());

            if (juriVote == 1)
            {
                cat1 += 1;
            }
            if (juriVote == 2)
            {
                cat2 += 1;
            } 
            if (juriVote ==3)
            {
                cat3 += 1;
            } 
            if (juriVote == 4)
            {
                cat4 += 1;
            }
            if (juriVote == 5)
            {
                cat5 += 1;
            } 
            if (juriVote == 6)
            {
                cat6 += 1;
            }
            if (juriVote == 7)
            {
                cat7 += 1;
            }
            if (juriVote == 8)
            {
                cat8 += 1;
            }
            if (juriVote == 9)
            {
                cat9 += 1;
            }
            if (juriVote == 10)
            {
                cat10 += 1;
            }    
        }
        if (cat1 >= cat2 && cat1 >= cat3 && cat1 >= cat4 && cat1 >= cat5 && cat1 >= cat6 && cat1 >= cat7 && cat1 >= cat8 && cat1 >= cat9 && cat1 >= cat10)
        {
            Console.WriteLine(1);
        }
        else  if (cat2 >= cat1 && cat2 >= cat3 && cat2 >= cat4 && cat2 >= cat5 && cat2 >= cat6 && cat2 >= cat7 && cat2 >= cat8 && cat2 >= cat9 && cat2 >= cat10)
        {
            Console.WriteLine(2);
        }
        else if (cat3>=cat1 && cat3 >= cat2 && cat3 >= cat4 && cat3 >= cat5 && cat3 >= cat6 && cat3 >= cat7 && cat3 >= cat8 && cat3 >= cat9 && cat3 >= cat10)
        {
            Console.WriteLine(3);
        }
        else if (cat4 >= cat1 && cat4 >= cat2 && cat4 >= cat3 && cat4 >= cat5 && cat4 >= cat6 && cat4 >= cat7 && cat4 >= cat8 && cat4 >= cat9 && cat4 >= cat10)
        {
            Console.WriteLine(4);
        }
        else if (cat5 >= cat1 && cat5 >= cat2 && cat5 >= cat3 && cat5 >= cat4 &&  cat5 >= cat6 && cat5 >= cat7 && cat5 >= cat8 && cat5 >= cat9 && cat5 >= cat10)
        {
            Console.WriteLine(5);
        }
        else if (cat6 >= cat1 && cat6 >= cat2 && cat6 >= cat3 && cat6 >= cat4 && cat6 >= cat5 && cat6 >= cat7 && cat6 >= cat8 && cat6 >= cat9 && cat6 >= cat10)
        {
            Console.WriteLine(6);
        }
        else if (cat7 >= cat1 && cat7 >= cat2 && cat7 >= cat3 && cat7 >= cat4 && cat7 >= cat5 && cat7 >= cat6 && cat7 >= cat8 && cat7 >= cat9 && cat7 >= cat10)
        {
            Console.WriteLine(7);
        }
        else if (cat8 >= cat1 && cat8 >= cat2 && cat8 >= cat3 && cat8 >= cat4 && cat8 >= cat5 && cat8 >= cat6 && cat8 >= cat7 && cat8 >= cat9 && cat8 >= cat10)
        {
            Console.WriteLine(8);
        }
        else if (cat9 >= cat1 && cat9 >= cat2 && cat9 >= cat3 && cat9 >= cat4 && cat9 >= cat5 && cat9 >= cat6 && cat9 >= cat7 && cat9 >= cat8 && cat9 >= cat10)
        {
            Console.WriteLine(9);
        }
        else if (cat10 >= cat1 && cat10 >= cat2 && cat10 >= cat3 && cat10 >= cat4 && cat10 >= cat5 && cat10 >= cat6 && cat10 >= cat7 && cat10 >= cat8 && cat10 >= cat9)
        {
            Console.WriteLine(10);
        }
    }
}

