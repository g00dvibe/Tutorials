//Write an expression that checks if given integer is odd or even.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EvenOfInteger
{
    class Task1
    {
        static void Main()
        {
            int strValue;
            Console.WriteLine("Please input a string for checking:");
            string word = Console.ReadLine();
            bool canWeDoIt = int.TryParse(word, out strValue); // A method i found over the msdn library that checks if a string could be converted to number without creating an overflow.


            if (canWeDoIt == false)
            {
                Console.WriteLine("This is not a valid string");
            }
            else
            {
                Console.WriteLine("This string could be checked");      // a little prank
                Thread.Sleep(100);                                      // thought it'd be fun
                Console.WriteLine("Please wait...");
                Thread.Sleep(10000);

                if (strValue % 2 == 0)
                {
                    Console.WriteLine("The string is even");
                }
                else
                {
                    Console.WriteLine("The string is odd");
                }
            }
        }
    }
}
