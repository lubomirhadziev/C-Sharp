using System;
using System.Linq;
using System.Numerics;
class FibonacciNumbers
{
    static void Main()
    {
        while (true)
        {
            var result = fibonacci(int.Parse(Console.ReadLine()));
            Console.WriteLine(result);
        }
    
    }
    static BigInteger fibonacci(int input)
    {
        var array = new BigInteger[input + 1];
        for (int i = 0; i <= input; i++)
        {
            if (i < 3)
            {
               array[i] = i; 
            }
            else
            {
                array[i] = array[i - 1] + array[i - 2];
            }
        }
        return array.Last();
    }
}
