using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = n / 1000;
        int b = (n / 100) % 10;
        int c = (n / 10) % 10;
        int d = n % 10;

        int sum = a + b + c + d;
        int reversed = int.Parse(d.ToString() + c.ToString() + b.ToString() + a.ToString());
        int lastDigit = int.Parse(d.ToString() + a.ToString() + b.ToString() + c.ToString());
        int exchangeSecondWithThird = int.Parse(a.ToString() + c.ToString() + b.ToString() + d.ToString());

        Console.WriteLine(sum);
        Console.WriteLine(reversed);
        Console.WriteLine(lastDigit);
        Console.WriteLine(exchangeSecondWithThird);
    }
}