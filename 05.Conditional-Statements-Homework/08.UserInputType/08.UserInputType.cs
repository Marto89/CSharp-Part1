using System;

class UserInputType
{
    static void Main()
    {
        Console.Write("Enter \"1\" for integer \"2\" for double or \"3\" for string :");
        string some = Console.ReadLine();
        char symbol = '*';

        switch(some)
        {
            case "1":
                Console.Write("Enter your integer: ");
                int i = int.Parse(Console.ReadLine());
                i += 1;
                Console.WriteLine("New integer is: {0}!",i); ; break;
            case "2":
                Console.Write("Enter your double: ");
                double d = double.Parse(Console.ReadLine());
                d += 1;
                Console.WriteLine("New double is: {0}!",d); break;
            case "3":
                Console.Write("Enter your string: ");
                string s = Console.ReadLine();
                Console.WriteLine("New string is \"{0}{1}\"",s,symbol);break;
            default:break;
        }
    }
}
