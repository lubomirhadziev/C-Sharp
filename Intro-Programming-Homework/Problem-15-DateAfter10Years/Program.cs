using System;

class Program
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        DateTime dateAfter10Years = new DateTime(date.Year+10, date.Month, date.Day);

        Console.WriteLine(dateAfter10Years);
    }
}