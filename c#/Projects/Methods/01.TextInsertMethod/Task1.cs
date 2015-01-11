// Write a method that asks the user for his name and prints “Hello, <name>” 
// (for example, “Hello, Peter!”). Write a program to test this method.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextInsertMethod
{
    class Task1
    {
        static void SayHello()
        {
            Console.Write("Please input your name:");
            string yourName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello, {0}!", yourName);
        }

        static void Main()
        {
            Console.Write("initiating method"); Thread.Sleep(100); Console.WriteLine("...");
            Console.WriteLine();
            SayHello();
            Console.WriteLine();
            Console.WriteLine("operation complete, good job!");
            Console.ReadLine();
        }
        
    }
}
