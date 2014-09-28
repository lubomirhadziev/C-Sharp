using System;

class Program
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object conca = hello + " " + world;
        string mix = conca.ToString();

        Console.WriteLine(mix);
    }
}
