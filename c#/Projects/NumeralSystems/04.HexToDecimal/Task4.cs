//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexToDecimal
{
    class Task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a hex number to be represented in decimal");
            //int number = int.Parse(Console.ReadLine());

            string counter = Console.ReadLine(); // number.ToString("X");

            int dec = int.Parse(counter, System.Globalization.NumberStyles.HexNumber);

            //Console.WriteLine("your number as hexadecimal: \n{0}", counter);
            Console.WriteLine();
            Console.WriteLine("number back to decimal:{0}", dec); 
        }
    }
}
