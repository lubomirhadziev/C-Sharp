using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            DateTime inputDate = DateTime.Parse(Console.ReadLine());

            if (inputDate.Hour >= 13 || inputDate.Hour < 3)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }

            Console.WriteLine();
        }
    }
}