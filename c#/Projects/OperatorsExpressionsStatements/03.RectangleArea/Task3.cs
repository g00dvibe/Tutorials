// Write an expression that calculates rectangle’s area by given width and height.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Task3
    {
        static void Main()
        {
            Console.Write("Input the width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Input the height: ");
            double height = double.Parse(Console.ReadLine());

            double area = width * height;       //That's the formula right?

            Console.WriteLine("The area of the rectangle is: {0}", area);
        }
    }
}
