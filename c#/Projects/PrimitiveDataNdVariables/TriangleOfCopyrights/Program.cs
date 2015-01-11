using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfCopyrights
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Triangle of copyright symbols";

            Console.OutputEncoding = Encoding.UTF8;
            char copyRightSymbol = '\u00A9';
            Console.WriteLine("    "+ copyRightSymbol);
            Console.WriteLine("  " + copyRightSymbol + copyRightSymbol + copyRightSymbol);
            Console.WriteLine(" " + copyRightSymbol+copyRightSymbol+copyRightSymbol+copyRightSymbol+copyRightSymbol);
            Console.WriteLine();
        }
    }
}