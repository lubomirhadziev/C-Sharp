using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        while (true)
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("{0}", (secondDate - firstDate).TotalDays);
            Console.WriteLine();
        }
    }
}