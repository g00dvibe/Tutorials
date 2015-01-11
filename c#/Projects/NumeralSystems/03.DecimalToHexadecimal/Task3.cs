//Write a program to convert decimal numbers to their hexadecimal representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number to be represented in hexadecimal");
            int number = int.Parse(Console.ReadLine());

            string counter = number.ToString("X");

            int dec2 = int.Parse(counter, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine("your number as hexadecimal: \n{0}", counter);
            Console.WriteLine();
            Console.WriteLine("number back to decimal:{0}", dec2); // little test just to ensure the method is reversible
        }
    }
}
