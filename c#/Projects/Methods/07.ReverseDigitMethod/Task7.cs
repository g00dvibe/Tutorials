// Write a method that reverses the digits
// of given decimal number. Example: 256  652


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDigitMethod
{
    class Task7
    {
        static void InvertNumber(long number)
        {
            long digits;

            while (number > 0) 
            {

                digits = number % 10;

                Console.Write(digits);

                number = number / 10;

            }             
        }
        static void Main()
        {
            Console.Write("Input the number you wan to reverse:");
            long myNumber = long.Parse(Console.ReadLine()); // intentionally did it with long
                                                            // because of excessive testing
            InvertNumber(myNumber);                         // to handle even more scenarios
            Console.WriteLine();
        }
    }
}
