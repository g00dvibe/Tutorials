using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianCoordinateSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c1 = 0;
            int c2 = 0;
            int c3 = 0;
            int c4 = 0;
            int c5 = 0;
            int c6 = 0;
            int c7 = 0;
            int c8 = 0;
            int c9 = 0;
            int c10 = 0;
            int value = 0;

            for (int i=1; i < n; i++)
            {
                value = int.Parse(Console.ReadLine());
                switch(value)
                {
                    case 1: c1++; break;
                    case 2: c2++; break;
                    case 3: c3++; break;
                    case 4: c4++; break;
                    case 5: c5++; break;
                    case 6: c6++; break;
                    case 7: c7++; break;
                    case 8: c8++; break;
                    case 9: c9++; break;
                    case 10: c10++; break;
                    default: break;
                }
                 
            }

            if ( (c1 >= c2) && (c1 >= c3) && (c1 >= c4) && (c1 >= c5) && (c1 >= c6) && (c1 >= c7) && (c1 >= c8) && (c1 >= c9) && (c1 >= c10))
            {
                Console.WriteLine(1);
            }
            else if ((c2 >= c1) && (c2 >= c3) && (c2 >= c4) && (c2 >= c5) && (c2 >= c6) && (c2 >= c7) && (c2 >= c8) && (c2 >= c9) && (c2 >= c10))
                Console.WriteLine(2);
            else if ((c3 >= c2) && (c3 >= c1) && (c3 >= c4) && (c3 >= c5) && (c3 >= c6) && (c3 >= c7) && (c3 >= c8) && (c3 >= c9) && (c3 >= c10))
                Console.WriteLine(3);
            else if ((c4 >= c2) && (c4 >= c3) && (c4 >= c1) && (c4 >= c1) && (c4 >= c6) && (c4 >= c7) && (c4 >= c8) && (c4 >= c9) && (c4 >= c10))
                Console.WriteLine(4);
            else if ((c5 >= c2) && (c5 >= c3) && (c5 >= c4) && (c5 >= c1) && (c5 >= c6) && (c5 >= c7) && (c5 >= c8) && (c5 >= c9) && (c5 >= c10))
                Console.WriteLine(5);
            else if ((c6 >= c2) && (c6 >= c3) && (c6 >= c4) && (c6 >= c5) && (c6 >= c1) && (c6 >= c7) && (c6 >= c8) && (c6 >= c9) && (c6 >= c10))
                Console.WriteLine(6);
            else if ((c7 >= c2) && (c7 >= c3) && (c7 >= c4) && (c7 >= c5) && (c7 >= c6) && (c7 >= c1) && (c7 >= c8) && (c7 >= c9) && (c7 >= c10))
                Console.WriteLine(7);
            else if ((c8 >= c2) && (c8 >= c3) && (c8 >= c4) && (c8 >= c5) && (c8 >= c6) && (c8 >= c7) && (c8 >= c1) && (c8 >= c9) && (c8 >= c10))
                Console.WriteLine(8);
            else if ((c9 >= c2) && (c9 >= c3) && (c9 >= c4) && (c9 >= c5) && (c9 >= c6) && (c9 >= c7) && (c9 >= c8) && (c9 >= c1) && (c9 >= c10))
                Console.WriteLine(9);
            else if ((c10 >= c2) && (c10 >= c3) && (c10 >= c4) && (c10 >= c5) && (c10 >= c6) && (c10 >= c7) && (c10 >= c8) && (c10 >= c9) && (c10 >= c1))
                Console.WriteLine(10);
        }
    }
}
