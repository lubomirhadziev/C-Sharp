using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = h * ((a + b) / 2);

            Console.WriteLine(area);
            Console.WriteLine();
        }
    }
}
