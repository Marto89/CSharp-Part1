using System;

class DeclaringStringsAndConcatenation
{
    static void Main()
    {
        Console.Title = ("7.HelloObject");
        string hello = "Hello";
        string world = "World !!!";
        object helloWorld = hello + " " + world;
        string stringHelloWorld = (string)helloWorld;
        Console.WriteLine(stringHelloWorld);
    }
}

