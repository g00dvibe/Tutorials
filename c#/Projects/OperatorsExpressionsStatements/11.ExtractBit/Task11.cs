//Write an expression that extracts from a given integer i the value of a given bit number b. 
//Example: i=5; b=2  value=1.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBit
{
    class Task11
    {
        static void Main()
        {
            //Most of the code is from the previous task.

            Console.Write("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Please enter the bit position to check (0 returns first bit) ");
            int bitPosition = int.Parse(Console.ReadLine()); // try out any value, but I think it actually shows one bitposition to the left of the given value
            int mask = 1;
            mask = mask << bitPosition;

            int addMask = number & mask;
            addMask = addMask >> bitPosition; //This line makes the value of addMask only the bit, making it easier to show in the console
            Console.WriteLine("The bit in position {0} has the value of: {1}", bitPosition, addMask);
            Console.WriteLine();


            // Those lines of code helps to understand the bitwise operation , which I used to clarify the job.
            string numberBinary = Convert.ToString(number, 2);
            string maskBinary = Convert.ToString(mask, 2);
            string addMaskBinary = Convert.ToString(addMask, 2);

            Console.WriteLine("{0,15} : number\n{1,15} : mask\n{2,15} : addMask", numberBinary, maskBinary, addMaskBinary);
        }
    }
}
