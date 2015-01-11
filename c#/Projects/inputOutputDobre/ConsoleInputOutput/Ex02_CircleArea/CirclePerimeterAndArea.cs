/* Exercise 2: Write a program that reads the radius r of a circle and prints its perimeter and area. */

using System;

namespace Ex02_CircleArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the radius of the circle: ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("Circle radius: {0} \nCircle perimeter: {1:0.00} \nCircle area: {2:0.00}", r, perimeter, area);
        }
    }
}
