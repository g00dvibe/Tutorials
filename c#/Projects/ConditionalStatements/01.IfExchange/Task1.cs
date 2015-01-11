//  Write an if statement that examines two integer variables and 
// exchanges their values if the first one is greater than the second one.


using System;

namespace IfExchange
{
    class Task1
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the first integer: ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the second integer: ");
            int secondInt = int.Parse(Console.ReadLine());
            int swap;

            if (firstInt > secondInt)              // Exchanges the values of "a" and "b", if the first integer is bigger than the second.
            {
                swap = firstInt;
                firstInt = secondInt;
                secondInt = swap;
                Console.WriteLine("The integers have switched places!!");
            }
            else
            {
                Console.WriteLine("The integers did not switch places.");
            }
        }
    }
}
