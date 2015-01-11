//Write a program to convert decimal numbers to their binary representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number to be represented in binary");
            int number = int.Parse(Console.ReadLine());
            string counter = "";

            while (number >= 1)
            {
                counter = (number % 2) + counter;
                number = number / 2;
            }

            Console.WriteLine("your number as binary: \n{0}", counter);
        }
    }
}
