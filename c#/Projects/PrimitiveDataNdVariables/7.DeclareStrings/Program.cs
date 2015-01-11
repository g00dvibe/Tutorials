using System;

namespace DeclareStrings
{
    class Program
    {
        static void Main()
        {
            string firstString = "Hello";
            string secondString = "World";
            object firstTwoStrings = firstString + "," + " " + secondString + "!";
            Console.WriteLine(firstTwoStrings);
            string thridString = (string)firstTwoStrings;
            Console.WriteLine(thridString); 
        }
    }
}
