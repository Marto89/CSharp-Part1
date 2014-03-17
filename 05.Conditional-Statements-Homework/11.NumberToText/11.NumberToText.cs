using System;

class NumberToText
{
    static void Main()
    {
        Console.Write("Enter your integer: ");
        int param = int.Parse(Console.ReadLine());

        if (param <= 999 && param >= 0)
        {
            int temp = param;
            switch (temp / 100)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;
                case 0:
                    break;
                default:
                    Console.Write("Error report!!");
                    break;                  
            }
            if (temp / 100 != 0 && temp % 100 != 0)
            {
                Console.Write("and ");
            }
            switch (temp / 10 % 10)
            {
                case 0:
                    break;
                case 1:
                    switch (temp % 10)
                    {
                        case 0:
                            Console.WriteLine("Ten");
                            break;
                        case 1:
                            Console.WriteLine("Elevan");
                            break;
                        case 2:
                            Console.WriteLine("Twelfe");
                            break;
                        case 3:
                            Console.WriteLine("Thirteen");
                            break;
                        case 4:
                            Console.WriteLine("Fourteen");
                            break;
                        case 5:
                            Console.WriteLine("Fifteen");
                            break;
                        case 6:          
                            Console.WriteLine("Sixteen");
                            break;       
                        case 7:          
                            Console.WriteLine("Seventeen");
                            break;       
                        case 8:          
                            Console.WriteLine("Eighteen");
                            break;
                        case 9:
                            Console.WriteLine("Nineteen");
                            break;
                        default:
                            Console.WriteLine("Error report!");
                            break;
                    }                    
                    break;
                case 2:
                    Console.Write("Twenty ");
                    break;
                case 3:
                    Console.Write("Thirty ");
                    break;
                case 4: 
                    Console.Write("Fourty ");
                    break;
                case 5: 
                    Console.Write("Fifty ");
                    break;
                case 6: 
                    Console.Write("Sixty "); 
                    break;
                case 7:
                    Console.Write("Seventy ");
                    break;
                case 8 :
                    Console.Write("Eighty ");
                    break;
                case 9:
                    Console.Write("Ninety ");
                    break;
                default:
                    Console.Write("Error report!");
                    break;

            }
            switch (temp % 10)
            {
                case 0:
                    if (temp == 0)
                    {
                        Console.WriteLine("Zero!");
                    }
                    Console.WriteLine("\n");
                    break;
                case 1:
                    if (temp / 10 % 10 == 1)
                    {
                        break;
                    }
                    Console.WriteLine("One");
                    break;
                case 2:
                    if (temp / 10 % 10 == 1)
                    {
                        break;
                    }                 
                    Console.WriteLine("Two");
                    break;
                case 3:
                    if (temp /10 % 10 == 1)
                    {
                        break;
                    }
                    Console.WriteLine("Three");
                    break;
                case 4:
                    if (temp /10 % 10 == 1)
                    {
                        break;
                    }
                    Console.WriteLine("Four");
                    break;
                case 5:
                    if (temp /10 % 10 == 1)
                    {
                         break;
                    }
                    Console.WriteLine("Five");
                    break;
                case 6:
                    if (temp /10 % 10 == 1)
                    {
                         break;
                    }
                    Console.WriteLine("Six");
                    break;
                case 7:
                    if (temp /10 % 10 == 1)
                    {
                         break;
                    }
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    if (temp /10 % 10 == 1)
                    {
                        break;
                    }
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    if (temp /10 % 10 == 1)
                    {
                        break;
                    }
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Error report!");
                    break;
            }
              
        }
        else
        {
            Console.WriteLine("Out of range!!");
        }
    }
}
