//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinaryToHex
{
    class Task6
    {
        // GetChar(15) -> 'F'
        static char GetChar(int character)
        {
            if (character >= 10) return (char)('A' + character - 10);
            else return (char)('0' + character);
        }

        // GetNumber("587", 2) -> 7
        static int GetNumber(string str, int number)
        {
            return str[number] - '0';
        }

        static string Base2ToBase16(string str)
        {
            if (str.Length % 4 != 0) return Base2ToBase16(new String('0', 4 - str.Length % 4) + str); // Padleft

            string h = String.Empty;

            // Read 4 by 4 and convert to hex
            for (int i = str.Length - 1; i >= 0; i -= 4)
            {
                int nibble = 0;

                for (int j = 0, power = 1; j < 4; j++, power *= 2)
                    nibble += GetNumber(str, i - j) * power;

                h = GetChar(nibble) + h;
            }

            return h;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a hex number to be represented in binary");
            //int number = int.Parse(Console.ReadLine());

            string counter = Console.ReadLine(); // number.ToString("X");

            Console.WriteLine("your number as binary: {0}", Base2ToBase16(counter));
        }
    }
}
