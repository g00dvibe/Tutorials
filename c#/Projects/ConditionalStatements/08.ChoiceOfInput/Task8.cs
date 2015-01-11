//Write a program that, depending on the user's choice inputs int, double or string variable.
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
//The program must show the value of that variable as a console output. Use switch statement.



using System;

namespace ChoiceOfInput
{
    class Task8
    {
        static void Main()
        {
            Console.WriteLine("Please select the input you would like to use in the program:");
            Console.WriteLine("\nFor integer press 1. \nFor double press 2. \nFor string press 3.");
            byte pick = byte.Parse(Console.ReadLine());
            dynamic value;
            switch (pick)
            {
                case 1: Console.WriteLine("You picked INTEGER! \nNow input the value:");
                        value = int.Parse(Console.ReadLine());
                        value++ ;
                        Console.WriteLine("Your number +1 is {0}", value);
                    break;

                case 2: Console.WriteLine("You picked DOUBLE! \nNow input the value:");
                        value = double.Parse(Console.ReadLine());
                        value++;
                        Console.WriteLine("Your number +1 is {0}", value);
                    break;

                case 3: Console.WriteLine("You picked STRING! \nNow input the value:");
                        value = Console.ReadLine();                        
                        Console.WriteLine("Your string's value + \"*\" is \n {0}", value + "*");
                    break;

                default: Console.WriteLine("The input is unrecognized, try again.");
                              break;
            }       
        }
    }
}
