using System;
//Write a program that reads a text file and prints on the console its odd lines.

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrintOddLines
{
    class Task1
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("d:/information/ufo.txt")) //it rly works, just type some other file dir.
            {
                string line;
                int lineCounter = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    if (lineCounter % 2 != 0)
                    {
                        Console.WriteLine(line);
                        Console.WriteLine();
                    }
                    lineCounter++;
                }
            }
        }
    }
}
