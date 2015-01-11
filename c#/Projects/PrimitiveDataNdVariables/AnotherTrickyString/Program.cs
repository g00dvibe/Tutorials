using System;

namespace AnotherTrickyString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("First option:");
            string firstOption = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(firstOption);
            Console.WriteLine();
            Console.WriteLine("Second option:");
            string secondOption = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(secondOption);
        }
    }
}
