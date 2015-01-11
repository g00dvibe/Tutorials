using System;

namespace VarExchange
{
    class Program
    {
        static void Main()
        {
            int varOne = 5;
            int varTwo = 10;
            Console.WriteLine("First cell: " + varOne + " Second cell: " + varTwo);
            varOne = varOne + varTwo;
            varTwo = varOne - varTwo;
            varOne = varOne - varTwo;
            Console.WriteLine("First cell: " + varOne + " Second cell: " + varTwo);
        }
    }
}
