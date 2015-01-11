// Write a program that enters the coefficients a, b and c of a quadratic equation
// "a*x2 + b*x + c = 0" and calculates and prints its real roots.
//  Note that quadratic equations may have 0, 1 or 2 real roots.


using System;


namespace QuadraticEquation
{
    class Task6
    {
        static void Main()
        {
            Console.WriteLine("The given equation is: \na*x2 + b*x + c = 0");
            Console.Write("input \"a\" :");
            double a = double.Parse(Console.ReadLine());
            Console.Write("input \"b\" :");
            double b = double.Parse(Console.ReadLine());
            Console.Write("input \"c\" :");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;
            Console.WriteLine("Discriminant \"D\" is: {0}", d);
            double x, x1, x2;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = {0} ; x2 = {1}", x1, x2);
            }
            else if (d < 0)
            {
                Console.WriteLine("There is no real roots!");
            }

            else if (d == 0)
            {
                x = -b / 2 * a;
                Console.WriteLine("x1 = x2 = {0}", x);
            }
        }
    }
}
