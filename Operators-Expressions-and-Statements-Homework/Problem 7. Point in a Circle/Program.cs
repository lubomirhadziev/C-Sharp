using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            double d = 2d;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool exp = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(d, 2);

            Console.WriteLine(exp);
            Console.WriteLine();
        }
    }
}
