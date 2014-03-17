using System;

class LeastMajorityMultiple
{
    static void Main()
    {
       int a = int.Parse(Console.ReadLine());
       int b = int.Parse(Console.ReadLine());
       int c = int.Parse(Console.ReadLine());
       int d = int.Parse(Console.ReadLine());
       int e = int.Parse(Console.ReadLine());

       for (int i = 1; i <1234567 ; i++)
       {
           if (i % a == 0 && i % b == 0 && i % c == 0 && i % d == 0 && i % e == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % a == 0 && i % b == 0 && i % c == 0 && i % d == 0 )
           {
               Console.WriteLine(i);
               break;
           }
           if (i % a == 0 && i % b == 0 && i % c == 0  && i % e == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % a == 0 && i % b == 0  && i % d == 0 && i % e == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % a == 0 && i % c == 0 && i % d == 0 && i % e == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % b == 0 && i % c == 0 && i % d == 0 && i % e == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % a == 0 && i % b == 0 && i % c == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % a == 0 && i % b == 0 && i % d == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % a == 0 && i % b == 0 && i % e == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % a == 0 && i % c == 0 && i % d == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % a == 0 && i % c == 0 && i % e == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % a == 0 && i % d == 0 && i % e == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % b == 0 && i % c == 0 && i % d == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % b == 0 && i % c == 0 && i % e == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % b == 0 && i % d == 0 && i % e == 0)
           {
               Console.WriteLine(i);
               break;
           }
           if (i % c == 0 && i % d == 0 && i % e == 0)
           {
               Console.WriteLine(i);
               break;
           }
       }
 
    }   
}       
        
        