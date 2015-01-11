//Write a program that finds the biggest of three integers using nested if statements.

using System;

namespace BiggestOfThree
{
    class Task3
    {
        static void Main()
        {
            Console.Write("input the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("input the second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("input the third number:");
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber || secondNumber == thirdNumber)
            {
                Console.WriteLine("All the numbers are equal");
            }
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("The first number is the biggest of them all");
            }
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The second number is the biggest of them all");
            }
            if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine("The third number is the biggest of them all");
            }
            

        }
    }
}
