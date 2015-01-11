// Write a program that shows the sign (+ or -) of the  
// product of three real numbers without calculating it.
// Use a sequence of if statements.


using System;

namespace TheSignOfDoom
{
    class Task2
    {
        static void Main()
        {   
            Console.WriteLine("The program will decide if the product of 3 numbers will be \npositive or negative without calculating them.");

            Console.WriteLine();

            Console.Write("input the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("input the second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("input the third number:");
            int thirdNumber = int.Parse(Console.ReadLine());
            int negativeNumCount = 0; // this object makes the whole preditcion a lot easier


            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("Theoretically the product of the 3 numbers will be 0");
            }
            if (firstNumber < 0)
            {
                negativeNumCount++;
            }
            if (secondNumber < 0)
            {
                negativeNumCount++;
            }
            if (thirdNumber < 0)
            {
                negativeNumCount++;
            }

            if (negativeNumCount == 1 || negativeNumCount == 3)
            {
                Console.WriteLine("\nTheoretically the product of the 3 numbers will be negative");
            }
            else
            {
                Console.WriteLine("\nTheoretically the product of the 3 numbers will be positive");
            }
         }
    }
}
