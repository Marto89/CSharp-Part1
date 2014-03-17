using System;

class Numbers2345etc
{
    static void Main()
    {
        int sighn = 1; //defines whether the number will be negative or positive
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine((i+1)*sighn); //we begin writing from 2 not 1 
            sighn = sighn * (-1); //the sighn of the next element will be changed (+ to - or vise versa)
        }
    }
}

