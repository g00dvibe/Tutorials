

using System;
using System.Collections.Generic;
using System.Text;

namespace pro7
{
    class Program
    {
        static void Main(string[] args)
        {



            string[] squares = new string[40];
            int die1 = 0, die2 = 0, roll = 0, turn = 10, pos = 0, countDouble = 0;
            Random myRand = new Random();
            System.IO.StreamReader squaresIn = new System.IO.StreamReader("monopoly.txt");

            for (pos = 0; pos < squares.Length; pos++)
            {
                squares[pos] = squaresIn.ReadLine();
                Console.WriteLine("[{0}]{1}", pos, squares[pos]);
            }



            pos = 0;
            for (int i = 1; i <= turn; i++)
            {
                die1 = myRand.Next(1, 7);
                die2 = myRand.Next(1, 7);
                Console.WriteLine("Turn {0}:\n \tI rolled {1} and {2}\tTotal - {3}", i, die1, die2, roll);
                roll = die1 + die2;
                for (int i = 1; i <= turn; i++)
                {
                    die1 = myRand.Next(1, 7);
                    die2 = myRand.Next(1, 7);
                    Console.WriteLine("Turn {0}:\n \tI rolled {1} and {2}\tTotal - {3}", i, die1, die2, roll);

                    roll = die1 + die2;
                    if (die1 == die2) // roll doubles
                    {
                        countDouble++;
                        Console.WriteLine("***** i rolled a double #{0}", countDouble);

                    }
                    else //not a double
                    {
                        countDouble = 0;
                    }
                    if (countDouble == 3)
                    {
                        Console.WriteLine("***** go to jail*****");
                        countDouble = 0;
                    }
                    else
                    {
                        move(squares, ref pos);
                        Console.WriteLine("I landed on {0}", squares[pos]);

                    }

                }
            }
        }//end of main

        static void move(string[] squares, ref int pos, int roll)
        {
            //pos = (pos + roll) % 7;   // keeps pos within the array no matter how high the roll
            pos += roll;
            if (pos >= squares.Length)
            {
                pos -= squares.Length;
                Console.WriteLine("I went around the board****************");
            }

            Console.WriteLine("\nGame over");
            Console.ReadLine();
        }

    }
}

