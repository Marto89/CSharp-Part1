using System;

class SevenlandNumbers
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        byte powerCounter = 0;
        int decimalNumber = 0;

        while (inputNumber != 0)
        { 
            byte lastNumber= (byte)(inputNumber%10) ;
            decimalNumber += lastNumber *(int) Math.Pow(7, powerCounter);
            powerCounter++;
            inputNumber /= 10;
        }
        //Console.WriteLine(decimalNumber);
        decimalNumber++;
        string result = "";
        while (decimalNumber != 0)
        {
            byte lastnumber= (byte)(decimalNumber%7);
            result = lastnumber+result;
            decimalNumber/=7;
        }
        Console.WriteLine(result);
    }
}

