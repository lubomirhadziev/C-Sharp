﻿using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double discriminant = Math.Pow(b, 2) - 4 * a * c;
        double x1 = (-b + Math.Sqrt(discriminant))/2*a;
        double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;

        Console.WriteLine("x1={0}; x2={1}", x1, x2);
    }
}