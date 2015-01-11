using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIItable
{
    class Program
    {
        static void Main()
        {
            for (int character = 0; character < 255; character++)
            {
                char symbol = (char)character;
                Console.WriteLine("{0} -> {1}", character, symbol);

            }
        }
    }
}
