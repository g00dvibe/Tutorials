//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInteger
{
    class Task4
    {
        static void Main()
        {
            Console.WriteLine("Please input a number: ");
            string input = Console.ReadLine();
            long number = long.Parse(input);

            long firstResult = number / 100;
            long result = firstResult % 10;

            if (result == 7)
            {
                Console.WriteLine("The third digit is actually 7, well done!");
            }
            else
            {
                Console.WriteLine("The third digit is not 7");
            }
        }
    }
}
