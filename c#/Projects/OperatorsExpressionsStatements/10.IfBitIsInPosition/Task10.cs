// Write a boolean expression that returns if the bit at position p (counting from 0) 
// in a given integer number v has value of 1. Example: v=5; p=1  false.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfBitIsInPosition
{
    class Task10
    {
        static void Main()
        {
            Console.Write("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Please enter the bit position to check (0 returns first bit) ");
            int bitPosition = int.Parse(Console.ReadLine()); // try out any value, but I think it actually shows one bitposition to the left of the given value
            int mask = 1;
            mask = mask << bitPosition;

            int addMask = number & mask;

            if (addMask != 0)
            {
                Console.WriteLine("The bit in position {0} of the number {1} is 1", bitPosition, number);
            }
            else
            {
                Console.WriteLine("The bit in position {0} of the number {1} is 0", bitPosition, number);
            }


            // Those lines of code helps to understand the bitwise operation , which I used to clarify the job.
            string numberBinary = Convert.ToString(number, 2);
            string maskBinary = Convert.ToString(mask, 2);
            string addMaskBinary = Convert.ToString(addMask, 2);

            Console.WriteLine("{0,15} : number\n{1,15} : mask\n{2,15} : addMask", numberBinary, maskBinary, addMaskBinary);
        }
    }
}
