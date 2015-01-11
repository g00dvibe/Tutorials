//Sort 3 real values in descending order using nested if statements.


using System;

namespace SortingValues
{
    class Task4
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
            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    if (secondNumber > thirdNumber)
                    {
                        Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                        firstNumber, secondNumber, thirdNumber); // 1,2,3
                    }
                    else
                    {
                        Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                        firstNumber, thirdNumber, secondNumber); // 1,3,2
                    }
                }
                else
                {
                    Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                    thirdNumber, firstNumber, secondNumber); // 3,1,2
                }
            }
            else if ((secondNumber > firstNumber) && (thirdNumber > secondNumber))
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                thirdNumber, secondNumber, firstNumber); // 3,2,1
            }
            else if ((secondNumber > firstNumber && firstNumber > thirdNumber))
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                secondNumber, firstNumber, thirdNumber); // 2,1,3
            }
            else if ((secondNumber > firstNumber && thirdNumber > firstNumber))
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}",
                secondNumber, thirdNumber, firstNumber); // 2,3,1
            }
            
        }
    }
}
