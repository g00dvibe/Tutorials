using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRun
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            

            for (double lenght = 0; lenght < (2 * (n - 1))/2; lenght++)
            {

                for (int i = 1; i <= n; i++)
                {

                    if (i == row) Console.Write("*");
                    if (i != row) Console.Write(".");                                     
                }
                row++;
                Console.WriteLine();
            }
            for (double lenght = 0; lenght < n; lenght++)
            {

                for (int i = 1; i <= n; i++)
                {

                    if (i == row) Console.Write("*");
                    if (i != row) Console.Write(".");
                }
                row--;
                Console.WriteLine();
            }
        }
    }
}
