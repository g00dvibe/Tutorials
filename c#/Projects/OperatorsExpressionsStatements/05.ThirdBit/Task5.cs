//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBit
{
    class Task5
    {
        static void Main()
        {
            Console.Write("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Please enter the bit position to check (0 returns first bit) ");
            int bitPosition = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << bitPosition;

            int addMask = number & mask;

            if (addMask != 0)
            {
                Console.WriteLine("The bit in position 3 is 1");
            }
            else
            {
                Console.WriteLine("The bit in position 3 is 0"); // It isn't 1
            }


        }
    }
}
