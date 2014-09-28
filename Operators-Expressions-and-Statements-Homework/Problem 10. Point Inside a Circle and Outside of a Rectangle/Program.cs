using System;

class Program
{
    static void Main()
    {
        double d = 1.5d;
        double circleX = 1d;
        double circleY = 1d;

        while (true)
        {
            //point x & y
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //find is point is in the circle
            bool inCircle = (Math.Pow(x - circleX, 2) + Math.Pow(y - circleY, 2)) <= Math.Pow(d, 2);

            //find is point is outside of rectangle
            bool inRectangle = (x >= -1 && x <= 5 && y >= -1 && y <= 1);

            //calculate result
            bool result = inCircle == true && inRectangle == false;

            Console.WriteLine("{0}", (result == true ? "yes" : "no"));
            Console.WriteLine();
        }
    }
}