// Write a method that returns the last digit of given integer as an English word. 
// Examples: 512  "two", 1024  "four", 12309  "nine".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNumAsWord
{
    class Task3
    {
        static string NumToWord(int num)
        {
            int lastDigit = num % 10;
            switch (lastDigit)
            {
                case 0: return "zero"; 
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "something went wrong..."; 
            }
            
        }

        static void Main()
        {
            Console.Write("Please input an integer:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The last digit of your number is {0}.", NumToWord(number));
        }
    }
}
