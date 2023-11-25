﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refreshers
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            //2 Types of Loops: For and While

            //for 
            //    (int i = 0; //before the loop starts
            //    i < length; //condition to be met if we want the code to keep running
            //    i++) //what happens after each loop

            Console.WriteLine("Count up to 10: ");
            for (int x = 1; x <= 10; x++)//change to x-- if we want to count backwards
            {
                Console.WriteLine(x);//If we want to print to 10
            }

            Console.WriteLine();
            Console.WriteLine("2^x: ");
            for (int x = 1; x <= 10; x++)
            {
                // 2^x  2 4 8 16 32 64...
                double result = Math.Pow(2, x);
                Console.WriteLine(result);
            }

            Console.WriteLine();
            Console.Write("What do you want me to count to?: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(i);
            }

            //WHILE- We DON'T know how many times the loop is going to run
            //Syntax is identical to an if statement while(condition) { }
            Console.WriteLine();
            Console.WriteLine("WHILE LOOPS:");
            Random numberGen = new Random();

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the di");

            while(roll !=6)
            {
                Console.ReadKey();

                roll = numberGen.Next(1, 7); //Gives us a random number between the two values given. First number is inclusive, the second is not
                Console.WriteLine("You rolled: " + roll);
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll a 6");

            //Wait before closing
            Console.ReadKey();

            

        }
    }
}
