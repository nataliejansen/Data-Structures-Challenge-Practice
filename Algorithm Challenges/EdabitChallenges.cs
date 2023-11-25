using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Challenges
{
    internal class EdabitChallenges
    {
        static void Main(string[] args)
        {
            //ARE THE NUMBERS EQUAL??
            //Create a function that takes two integers and checks if they are equal
            //IsEqual(5, 6) ➞ false
            //IsEqual(1, 1) ➞ true
            //IsEqual(36, 35) ➞ false

            //If we know the number it can be done this way
            int x = 5;
            int y = 6;
            if (x == y)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
