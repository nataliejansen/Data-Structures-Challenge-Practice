using System;
using System.Collections.Generic; //Mandatory
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class HashSet
    {
        static void Main(string[] args)
        {
            //What is Hashing?: It is a technique or process of mapping keys, and values into the has table by using a hash function. It is done for faster access to elements. The efficiency of mapping depends on the efficiency of the has function used.

            //HashSet: an unordered collection of unique elements. This supports the implementation of sets and uses the hash table for storage. 
            //          When to use it?: When we want to prevent duplicate elements from being placed in the collection. The performance of the HashSet is much better in                               comparison to the list.
            //IMPORTANT POINTS:
            // The HashSet class implements the ICollection, IEnumerable, IReadOnlyCollection, ISet, IEnumerable, IDeserializationCallback, and ISerializable interfaces.
            // In HashSet, the order of the element is not defined. You cannot sort the elements of HashSet
            // The elements must be unique and duplicates are not allowed
            // Provides many mathematical set operations, such as intersection, union, and difference
            // The capacity of HashSet is the number of elements it can hold
            // a HashSet is a dynamic collection and the size of the HashSet is automatically increased when the new elements are added.
            // In HashSet, you can only store the same type of elements.

            //Creating a HashSet
            //The HashSet class provides 7 different types of constructors, which are used to create a HashSet. (Right now, we are only using HashSet())

            //HashSet() is used to create an instance of the HashSet class that is empty and uses the default equality comparer for the set type.
            //Syntax for creation: HashSet<Type_of_hashset> Hashset_name = new HashSet<Type_of_hashset>(); 
            //If you want to add elements in your HashSet, then use Add() method. You can also store elements in your HashSet using the collection initializer
            
            //Create HashSet using HashSet class
            HashSet<int> hash = new HashSet<int>();
            //Add the elements using the Add() method
            hash.Add(0);
            hash.Add(1);
            hash.Add(2);
            hash.Add(3);
            hash.Add(4);
            hash.Add(5);
            Console.WriteLine("Elements of hash");
            foreach (int i in hash)
            {
                Console.WriteLine(i);
            }

            //Create another HashSet using the collection initializer
            HashSet<int> hash2 = new HashSet<int>() { 0, 10, 20, 30, 40, 50};
            Console.WriteLine("Elements of hash2");
            foreach(int i in hash2)
            {
                Console.WriteLine(i);
            }

            //Remove elements from the HashSet: The HashSet<T> class provides 3 different methods to remove elements
            //  - Remove(): used to remove the specified element from a HashSet object
            //  - RemoveWhere(): used to remove all elements that match the conditions defined by the specified predicate from a HashSet collection
            //  - Clear(): This method is used to remove all elements from a HashSet object
            Console.WriteLine("Total number of elements present (Before Removal)" +
                                " in hash: {0}", hash.Count);
            //Remove element from HashSet using the Remove method
            hash.Remove(0);
            //After using remove method
            Console.WriteLine("Total number of elements present (After Removal)" +
                    " in hash: {0}", hash.Count);

            //Remove all elements from HashSet 
            //using Clear method
            hash.Clear();
            Console.WriteLine("Total number of elements present (After Clearning)" +
                    " in hash: {0}", hash.Count);

            //SET OPERATIONS: The HashSet class also provides some methods that are used to perform different operations on sets and the methods are:
            //  - UnionWith(IEnumerable): This method is used to modify the current HashSet object to contain all elements that are present in itself,
            //                            the specified collection, or both
                Console.WriteLine("\nUnionWith:");
                //EXAMPLE:
                HashSet<string> myhash1 = new HashSet<string>();

                // Add the elements in HashSet
                // Using Add method
                myhash1.Add("C");
                myhash1.Add("C++");
                myhash1.Add("C#");
                myhash1.Add("Java");
                myhash1.Add("Ruby");

                // Creating another HashSet
                // Using HashSet class
                HashSet<string> myhash2 = new HashSet<string>();

                // Add the elements in HashSet
                // Using Add method
                myhash2.Add("PHP");
                myhash2.Add("C++");
                myhash2.Add("Perl");
                myhash2.Add("Java");

                //Using UnionWith method
                myhash1.UnionWith(myhash2);
                foreach (var i in myhash1)
                {
                    Console.WriteLine(i);
                }
            myhash1.Clear();
            myhash2.Clear();

            // - IntersectWith(IEnumerable): This method is used to modify the current HashSet object to contain only elements that are
            //                              present in that object and in the specified collection.

                Console.WriteLine("\nIntersectWith:");
                //EXAMPLE:

                // Add the elements in HashSet
                // Using Add method
                myhash1.Add("C");
                myhash1.Add("C++");
                myhash1.Add("C#");
                myhash1.Add("Java");
                myhash1.Add("Ruby");

                // Add the elements in HashSet
                // Using Add method
                myhash2.Add("PHP");
                myhash2.Add("C++");
                myhash2.Add("Perl");
                myhash2.Add("Java");
            
                //Using InsersectWith method
                myhash1.IntersectWith(myhash2);
                foreach (var i in myhash1)
                {
                    Console.WriteLine(i);
                }
                myhash1.Clear();
                myhash2.Clear();

            // - ExceptWith(IEnumerable): This method is used to remove all elements in the specified collection from the current HashSet object.

                Console.WriteLine("\nExceptWith:");
                //EXAMPLE:

                // Add the elements in HashSet
                // Using Add method
                myhash1.Add("C");
                myhash1.Add("C++");
                myhash1.Add("C#");
                myhash1.Add("Java");
                myhash1.Add("Ruby");

                // Add the elements in HashSet
                // Using Add method
                myhash2.Add("PHP");
                myhash2.Add("C++");
                myhash2.Add("Perl");
                myhash2.Add("Java");

                // Using ExceptWith method
                myhash1.ExceptWith(myhash2);
                foreach(var i in myhash1)
                {
                    Console.WriteLine(i);
                }
            myhash1.Clear();
            myhash2.Clear();

        }
    }
}
