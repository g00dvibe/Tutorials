/* Exercise 5: Write a program that gets two numbers from the console and prints the greater of them.
 * Don’t use if statements. */

using System;

namespace GreaterOfTwo
{
    class Task5
    {
        static void Main()
        {
            Console.Write("Please, enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please, enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            int theGreater = Math.Max(firstNum, secondNum);

            Console.WriteLine("\nThe greater number is {0}.", theGreater);
        }
    }
}
