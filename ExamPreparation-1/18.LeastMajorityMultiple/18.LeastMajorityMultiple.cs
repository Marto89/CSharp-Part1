using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        checked
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int restA = 1;
            int restB = 1;
            int restC = 1;
            int restD = 1;
            int restE = 1;
            for (int i = 4; i < a*b*c*d; i++)
            {
                restA = i % a;
                restB = i % b;
                restC = i % c;
                restD = i % d;
                restE = i % e;
                if ((restA == 0 && restB == 0 && restC == 0) || (restB == 0 && restC == 0 && restD == 0) || (restC == 0 && restD == 0 && restE == 0) || (restD == 0 && restE == 0 && restA == 0) || (restE == 0 && restA == 0 && restB == 0) || (restA == 0 && restB == 0 && restD == 0) || (restA == 0 && restC == 0 && restD == 0) || (restA == 0 && restC == 0 && restE == 0) || (restB == 0 && restC == 0 && restE == 0) || (restB == 0 && restD == 0 && restE == 0))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
