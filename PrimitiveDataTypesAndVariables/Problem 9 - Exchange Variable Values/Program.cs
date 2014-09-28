using System;

class Program
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;
        byte change = 0;

        Console.WriteLine(a);
        Console.WriteLine(b);

        change = b;
        b = a;
        a = change;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
