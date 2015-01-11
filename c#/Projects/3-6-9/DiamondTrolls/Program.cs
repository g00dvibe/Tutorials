using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondTrolls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 6 + ((n - 3) / 2)*3;
            int width = n*2+1;
            int rowCount = 0;
            int columnCount = 0;
            string dot = ".";
            string slash = "*";

            for (int i = 0; i < height; i++)
            {                
                for (int j = 0; j < width; j++)
                {

                    while (j < width)
                        Console.Write(dot);
                    columnCount++;
                }
                Console.WriteLine();
                rowCount++;
                
            }
        }
    }
}
/* n=3
..***..
.*.*.*. 
 
*******
 
.*.*.*.
..***..
...*...
*/