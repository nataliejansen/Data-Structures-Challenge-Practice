using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Challenges
{
    internal class MaximumProduct
    {
        static void Main(string[] args)
        {
            //Write code to create a function that accepts an array of numbers,
            //finds the largest two numbers, and returns the product of the two

            //EXAMPLE 1:
            int[] nums = { 3, 4, 5, 2 }; //Output should be 12
            Array.Sort(nums);
            Console.WriteLine((nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1));

            //EXAMPLE 2:
            int[] moreNums = { 10, 2, 7, 9, 3 }; 
            Array.Sort(moreNums);
            Console.WriteLine((moreNums[moreNums.Length - 1] -1) * (moreNums[moreNums.Length - 2] -1));
        }
    }
}
