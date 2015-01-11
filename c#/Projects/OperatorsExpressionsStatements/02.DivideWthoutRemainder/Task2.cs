// Write a boolean expression that checks for given integer 
// if it can be divided (without remainder) by 7 and 5 in the same time.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWthoutRemainder
{
    class Task2
    {
        static void Main()
        {
            
            Console.WriteLine("Enter your number to check if it can be divided by 5 and 7 at the same time:");
            bool notAgain = false;
            int number = int.Parse(Console.ReadLine());

            while ( notAgain == false) //

            {
                if ((number % 5 == 0) && (number % 7 == 0))
                {
                    Console.Beep(); Console.Beep(); Console.Beep();
                    Console.WriteLine("This is THE NUMBER!");
                    notAgain = true;
                }
                else
                {
                    Console.WriteLine("Please try again with different number. :(");
                    number = int.Parse(Console.ReadLine());
                }
                
            }
        }
    }
}
