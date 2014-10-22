using System;

class Program
{
    static void Main()
    {
        char isLeap = char.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        int hw = int.Parse(Console.ReadLine());
        int leap = (isLeap == 't' ? 3 : 0);

        h = h / 2;
        double result = ((((52 - hw) * 2) / 3) + hw) + leap;

        //
        result += h;

        Console.WriteLine("{0}", (long)result);
    }
}