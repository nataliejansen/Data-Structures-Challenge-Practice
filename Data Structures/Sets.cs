using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class Sets
    {
        static void Main(string[] args)
        {
            #region Set Intro


            //SET -- A mathematical model for a collection of different things; a set contains elements or members, which can be mathematical objects of any kind of numbers,       symbols, points in space, lines, or other geometrical shapes, variables, and even other sets.
            //A set can be implemented in various ways but the most common ways are:
            // - Hash-based Set: the set is represented as a hash table where each element in the set is stored in a bucket based on its hash code
            // - Tree-based Set: In this implementation, the set is represented as a binary search tree where each node in the tree represents an element in the set.

            //WHY SETS? The main advantage of using a set data structure is that it allows you to perform operations on a collection of elements in an efficient and organized way.

            //TYPES OF SET DATA STRUCTURE:
            //  - Unordered Set: an unordered associative container implemented using a hash table where keys are hashed into indices of a hash table so that the insertion     is always randomized. All operations on the unordered set take constant time O(1) on an average which can go up to O(n) in the worst case which depends on      the internally used hash function, but practically they perform very well and generally provide a constant time lookup operation.
            //  - Ordered Set: the most common set data structure. It is generally implemented using balanced BSTs and it supports O(log n) lookups, insertions, and deletion   operations.

            //SETS IN C# internally implemented as (Hash-Table)
            //comes under the System.Collections.Generic namespace. It is used in a situation where we want to prevent duplicates from being inserted in the collection. Performance-wise, it is better in comparison to the list.

            #endregion

            #region Arrays vs. Sets


            //ARRAYS VS SETS
            //Arrays can have duplicate values --> Sets cannot
            //An Array is an Ordered Collection --> Set is an Unordered Collection
            //An Array is Static in size --> a Set is Dynamic in size
            //Elements of an array are accessed using their index --> Sets are iterated over to retrieve the value
            //You can Add, remove, and access elements in an array --> Set operations like union, intersection, and difference
            //An Array is stored as contiguious blocks of memory --> Sets are implemented using linked list or trees

            #endregion

            #region Basic Implementation
            //IMPLEMENTATION:
            HashSet<int> hs = new HashSet<int>(); //Declaring the set

            //inserting elements in the set
            hs.Add(10);
            hs.Add(5);
            hs.Add(12);
            hs.Add(4);

            //printing elements of the set
            foreach (int i in hs)
            {
                Console.WriteLine(i + " ");
            }

            //check if 10 is present inside the set
            if (hs.Contains(10))
            {
                Console.WriteLine("Element is present in the HashSet");
            }
            else
            {
                Console.WriteLine("Element is not present in the HashSet");
            }

            //erasing 5 from the set
            hs.Remove(5);

            //printing the updated elements in the set
            foreach (int i in hs)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            //finding the minimum and maximum elements in the set

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            foreach (int element in hs)
            {
                if (element < minValue)
                {
                    minValue = element;
                }
                if (element > maxValue)
                {
                    maxValue = element;
                }
            }

            //printing the minimum element
            Console.WriteLine("Min element: " + minValue);
            //printing the max element
            Console.WriteLine("Max element: " + maxValue);
            //printing the size of the set
            Console.WriteLine("Size of the HashSet: "
                                + hs.Count);

            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - -");
            Console.WriteLine();
            #endregion

            #region Needs More Research
            // ****** DO MORE RESEARCH ON THIS! ******
            //OPERATIONS ASSOCIATED WITH SET DATA
            //IMPLEMENTATION:

            ////Create an empty HashSet
            //HashSet<int> set = new HashSet<int>();
            ////Use the Add() to add elements into the set
            //set.Add(1);
            //set.Add(2);
            //set.Add(3);
            //set.Add(4);
            //set.Add(5);

            ////Displaying the set
            //Console.WriteLine("Set: ");
            //foreach (int element in set)
            //{
            //    Console.WriteLine(element + " ");
            //}
            //Console.WriteLine();

            ////Creating an iterator
            //IEnumerator<int> value = set.GetEnumerator();

            ////Displaying the values after iterating through the iterator
            //Console.WriteLine("The iterator values are: ");
            //while (value.MoveNext())
            //{
            //    Console.WriteLine(value.Current);
            //}
            #endregion

            #region Properties of Set Data Structure

            //Storing Order - The set stores the elements in sorted order
            //Value Characteristics - All the elements in a set have unique values
            //Values Nature - The value of the element cannot be modified once it is added to the set, though it is possible to remove and then add the modified value of that element. Thus, the values are immutable.
            //Search Technique - Sets follow the Binary search tree implementation
            //Arranging Order - The values in a set are unindexed

            #endregion

            #region Applications of Set Data Structure

            //Sets are abstract data types that can be used to store unique elements in a collection. Here are some common applications of sets:
            //Removing duplicates: If you have a large collection of data, you can use a set to easily remove duplicates and store only unique elements
            //Membership testing: Sets provide efficient operations for checking if an element is a member of the set, which is useful in various algorithms and data structures.
            //Set operations: Sets can be used to perform operations such as union, intersection, and difference, which are useful in mathematical set theory and computer science
            //Graph algorithms: Sets can be used to represent berytices and edges in graph algorithms, allowing for efficient operations such as finding connected components, detecting cycles, and computing minimum spanning trees.
            //Cache replacement: Sets can be used to implement cache replacement policies, where the oldest or least recently used elements are removed when the cache is full.
            //Database indexing: Sets can be used to implement indexes in databases, allowing for fast seaching and retrieval of data based on specific keys or attributes.

            #endregion

            #region Advantages of Set Data Structure

            //Set can be used to store unique values in order to avoid duplications of elements present in the set.
            //Elements in a set are stored in a sorted fashion which makes it effecient.
            //Set is dynamic, so there is no error of overflowing of the set
            //Sets provide fast and efficient operations for checking if an element is present in the set or not
            //Sets can be implemented using different data structures, such as HashSets and TreeSets, each with its own advantages and use cases
            //Sets can be used in a variety of applications, including algorithms, data analysis, and databases
            //Sets can be used to improve performance in many algorithms by providing fast lookups


            #endregion

            #region Disadvantages of Set Data Structure

            //Elements in a set can only be accessed with pointers, there is no indexing in a set like arrays
            //Set is very complex to implement because of its structure and properties
            //Not suitable for large data sets
            //Sets can only store elements of a specific type
            //Sets can use more memory than other data structures, such as arrays or lists because they store each element in a seperate location

            #endregion

            #region Find Union and Intersection of Two Unsorted Arrays

            //Method 1: Using Set

            static void getUnion(int[] a, int n, int[] b, int m)
            {

                int[] arr1 = { 7, 1, 5, 2, 3, 6 };
                int[] arr2 = { 3, 8, 6, 20, 7 };

                //Union should print to --> {1, 2, 3, 5, 6, 7, 8, 20}
                //Intersection should print to --> {3, 6, 7}

                //Defining set container s
                HashSet<int> s = new HashSet<int>();

                //inserting the array elements
                for (int i = 0; i < n; i++)
                {
                    s.Add(a[i]);
                }
                for (int i = 0; i < m; i++)
                {
                    s.Add(b[i]);
                }
                Console.WriteLine("Number of elements after union operation: "
                    + s.Count + "\n");
                foreach (int i in s)
                {
                    Console.WriteLine(i + " "); //s will contain only distinct elements from array a and b
                }   

            }
            //Driver Code
            static void Main(string[] args)
            {
                int[] a = { 1, 2, 5, 6, 2, 3, 5, 7, 3 };
                int[] b = { 2, 4, 5, 6, 8, 9, 4, 6, 5, 4 };

                getUnion(a, 9, b, 10);
            }

            #endregion


        }
    }
}
