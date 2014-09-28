using System;

class Program
{
    static void Main()
    {
        char c;
        for (int i = 0; i <= 255; i++)
        {
            c = (char)i;
            if (char.IsSymbol(c) || char.IsLetter(c) || char.IsNumber(c))
            {
                Console.WriteLine("{0} -> {1}", i, (char)i);
            }
        }
    }
}