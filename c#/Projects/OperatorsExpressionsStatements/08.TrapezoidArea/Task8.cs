//Write an expression that calculates trapezoid's area by given sides a and b and height h.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class Task8
    {
        static void Main()
        {
            Console.WriteLine("Enter the parameters of a trapezoid ony by one to calculate it's area");

            Console.Write("Side a: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Side b: ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double area = ((sideA + sideB) / 2) * height;  // This is where the magic happens!

            Console.WriteLine("The trapezoid has an area of {0} square inches maybe.", area); // "maybe" added just for fun
        }
    }
}
