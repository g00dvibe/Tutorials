//Write a program that compares two char arrays lexicographically (letter by letter).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArr
{
    class Task3
    {
        static void Main()
        {
            Console.WriteLine("Input first array with some text:");
            char[] firstArr = Console.ReadLine().ToCharArray(); 
            Console.WriteLine("Input second array with some more text:");
            char[] secondArr = Console.ReadLine().ToCharArray();
            int smallerArr;

            Console.WriteLine();

            if (firstArr.Length >= secondArr.Length)
            {
                smallerArr = secondArr.Length;
                Console.WriteLine("The second array is shorter!");
            }
            else
            {
                smallerArr = firstArr.Length;
                Console.WriteLine("The first array is shorter!");
            }
            Console.WriteLine();
            Console.Write("Starting spell check, please wait"); System.Threading.Thread.Sleep(400); Console.Write("."); System.Threading.Thread.Sleep(500); Console.Write("."); System.Threading.Thread.Sleep(800); Console.Write(".");
            Console.WriteLine();
            for (int i = 0; i < smallerArr; i++)
            {
                Console.WriteLine("Position to be compared - {0}", i);
                if (firstArr[i] == secondArr[i]) Console.WriteLine("{0} = {1}", firstArr[i], secondArr[i]);
                if (firstArr[i] != secondArr[i]) Console.WriteLine("{0} != {1}", firstArr[i], secondArr[i]);
                
            }
            Console.WriteLine();
        }
    }
}
