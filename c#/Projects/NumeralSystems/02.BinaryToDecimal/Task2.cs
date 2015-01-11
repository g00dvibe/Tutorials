//Write a program to convert binary numbers to their decimal representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("input the binary numer to convert to decimal:");

            string bin = Console.ReadLine();
            long decimalNum = Convert.ToInt64(bin, 2);
            Console.WriteLine("number after conversion: {0}", decimalNum);
        }
    }
}
