using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Challenges
{
    internal class ReverseInPlace
    {
        static void Main(string[] args)
        {
            //REVERSE an array in place without using the built-in 'Reverse' method
            //EXAMPLE 1:
            int[] num = { 0, 1, 2, 3, 4, };
            for (int i=num.Length-1; i>=0; i--)
            {
                Console.WriteLine((i));
            }

            //EXAMPLE 2:
            string[] str = { "Hello", "my", "name", "is", "Natalie" };
            string revStr = " ";
            for (int i= str.Length - 1; i>=0; i--)
            {
                revStr = revStr + str[i] + " ";
            }
            Console.WriteLine(revStr);
            

            
            

        }
    }
}
