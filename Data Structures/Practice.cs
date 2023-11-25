using System;
using System.Collections.Generic;
using System.Collections; //added to utilize hashtable
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class Practice
    {
        static void Main(string[] args)
        {

            #region Addition
            Console.WriteLine("ADDITION:");
            //Create a function that takes 2 numbers. Your function should return the sum of the 2 numbers passed in.
            //EXAMPLE: 2 + 3 = 5
            int x = 2;
            int y = 3;
            int sumTwoNumbers = x + y;
            Console.WriteLine(sumTwoNumbers);

            //EXAMPLE 2: 2 + 7 = 9
            int a = 2;
            int b = 7;
            int sumTwoNums = a + b;
            Console.WriteLine(sumTwoNums);


            Console.WriteLine();
            #endregion

            #region Conditional
            Console.WriteLine("CONDITIONAL:");
            //CREATE FUNCTIONS BELOW THAT TAKE 2 NUMBERS. 
            //If the first number is bigger than the second number, return `"The first number was bigger!"`.
            //If the second number is bigger than the first number, return `"The second number was bigger!"`.
            //If the numbers are the same, return `"The numbers are the same!"`.

            //EXAMPLE 1: 3, 2 -> should log "The first number was bigger!"
            int c = 3;
            int c2 = 2;
            if (c < c2)
            {
                Console.WriteLine("The second number was bigger!");
            }
            else if (c > c2)
            {
                Console.WriteLine("The first number was bigger!");
            }
            else
            {
                Console.WriteLine("The numbers are the same!");
            }

            //EXAMPLE 2: 2, 7 -> should log "The second number was bigger!"
            int c3 = 2;
            int c4 = 7;
            if (c3 > c4)
            {
                Console.WriteLine("The first number was bigger!");
            }
            else if (c3 < c4)
            {
                Console.WriteLine("The second number was bigger!");
            }
            else
            {
                Console.WriteLine("The numbers are the same!");
            }

            //EXAMPLE 3: 7, 7
            int c5 = 7;
            int c6 = 7;
            if( c5 > c6)
            {
                Console.WriteLine("first");
            }
            else if ( c5 < c6)
            {
                Console.WriteLine("last");
            }
            else
            {
                Console.WriteLine("same");
            }

            Console.WriteLine();
            #endregion

            #region Array
            Console.WriteLine("ARRAYS:");
            //Create a function that takes in an array. Add up the first and last values in the array

            //EXAMPLE 1:
            int[] array = { 1, 2, 3, 4, 5 };

            int first = array.First();
            int last = array.Last();
            int sum = first + last;

            Console.WriteLine(sum); //Outputs 6

            //EXAMPLE 2:
            int[] array2 = { 6, 7, 8, 9, 10, 11, 12 };

            int first2 = array2.First();
            int last2 = array2.Last();
            int sum2 = first2 + last2;

            Console.WriteLine(sum2); //Outputs 18








            Console.WriteLine();
            #endregion

            #region Loops, Arrays, and Concatenation

            Console.WriteLine("LOOPS, ARRAYS, AND CONCATENATION:");
            //Create a function that takes two parameters. The first parameter is an array, the second will be a number
            //Your function should return a string that combines all of the values starting at the index of the number passed in through the end of the array

            //EXAMPLE 1: "ASDF", "BLAH", "Oh!", "Hi", "There!", 3 --- Should log Hi There!
            string[] stringArray = { "ASDF", "BLAH", "Oh!", "Hi", "There!" };
            int number = 3;

            Console.WriteLine(stringArray[3] + " " + stringArray[4]);

            //EXAMPLE 2: "ASDF", "BLAH", "Oh!", "Hi", "There!", 2 --- Should log Oh! Hi There!
            string[] stringArray2 = { "ASDF", "BLAH", "Oh!", "Hi", "There!" };
            int number2 = 2;

            Console.WriteLine(stringArray2[2] + " " + stringArray2[3] + " " + stringArray2[4]);


            Console.WriteLine();
            #endregion

            #region Looping Through an Array of Objects

            //Create a function that takes in an array of employee objects. Each employee object will come in with a property called `yearsOfExperience`.
            //Your function should return the total years of experience for all of the employees.
            //Parameters: Tony - 10 years, Carla - 4 years, Kris - 14 years

            //EXAMPLE 1: Tony and Carla's years of experience combined:





            Console.WriteLine();

            #endregion

            #region Loops and Two Dimensional Arrays
            Console.WriteLine("LOOPS AND TWO DIMENSIONAL ARRAYS");
            //Create a function that takes in an array of arrays. Add up all the numbers in all of the arrays and return the value/
            //EXAMPLE 1: [1, 2, 0], [3, 4, 5] --- should log 15
            int[,] multiArray = { {1, 2, 0}, {3, 4, 5} };
            int[] multiOne = { 1, 2, 0 };
            int[] multiTwo = { 3, 4, 5 };

            Console.WriteLine(multiOne.Sum() + multiTwo.Sum());
            


            #endregion

            #region HashSet

            #endregion

            #region Dictionary

            #endregion

            #region HashTable

            #endregion

        }
    }
}
