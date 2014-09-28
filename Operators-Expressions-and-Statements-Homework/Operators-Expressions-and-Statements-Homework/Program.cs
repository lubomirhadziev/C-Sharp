using System;

class Program
{
    static void Main()
    {
        int digit = 777;
        int result = (digit/100)%10;
    
        Console.WriteLine(result == 7);
    }
}
