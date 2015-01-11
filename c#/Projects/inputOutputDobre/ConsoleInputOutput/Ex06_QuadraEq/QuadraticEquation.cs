/* Exercise 6: Write a program that reads the coefficients a, b and c of
 * a quadratic equation ax2+bx+c=0 and solves it (prints its real roots). */

using System;

namespace Ex06_QuadraEq
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Please, enter a greater value than 0!");
            }
            else
            {
                double d = (b + b) - (4 * a * c);
                if (d > 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("The equation roots are:\nX1: {0:0.00}\nX2: {1:0.00}", x1, x2);
                }
                else if (d==0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("The eqation have only one root: {0}", x);
                }
                else if (d < 0)
                    Console.WriteLine("The equation doesn't have roots.");
            }
        }
    }
}
