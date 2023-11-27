using System;
using System.Collections; //Added for access to Hashtable class
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class HashTable
    {
        static void Main(string[] args)
        {

            #region GeeksForGeeks Notes

            
            //HASHTABLES
            //a HashTable is a collection of key/value pairs that are arranged based on the hash code of they key. In other words, a Hashtable is used to create a collection that uses a hash table for storage. It generally optimizes lookup by calculating the hash code of every key and storing it into another basket automatically and when you access the value from the hashtable at that time it matches the hashcode with the specified key. It is the non-generic type of collection that is defined in the System.Collections namespace
            //IMPORTANT POINTS:
            // - The key cannot be null, but the value can be
            // - In Hashtable, key objects must be immutable as long as they are used as keys in the Hashtable
            // The capacity of a Hashtable is the number of elements that Hashtable can hold
            // A hash function is provided by each key object in the Hashtable
            // The Hashtable class implements the IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, and ICloneable interfaces.
            // In the hashtable, you can store elements of the same type and of different types
            // The elements of the hashtable that is a key/value pair are stored in DictionaryEntry, so you can also cast the key/value pairs to a DictionaryEntry
            // That key must be unique. Duplicate keys are not allowed.

            //How to Create a Hashtable
            //Use the Hashtable() constructor (There are 16 different types of constructors that are used to create a hashtable)
            //BE SURE TO ADD System.Collections; to your using statements!!

            //Create
            Hashtable ht = new Hashtable();

            //Add key/value pairs using the Add() method
            ht.Add("A1", "Welcome");
            ht.Add("A2", "to");
            ht.Add("A3", "GeeksforGeeks");

            Console.WriteLine("Key and Value pairs from ht:");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("{0} and {1}", item.Key, item.Value);
            }

            Console.WriteLine();

            //Create another hashtable without using the Add()
            Hashtable ht2 = new Hashtable() 
              {
                { 1, "hello" },
                { 2, 234 },
                { 3, 230.45 },
                {4, null }
              };
            Console.WriteLine("\nKey and Value pairs from ht2:");
            foreach(var i in ht2.Keys)
            {
                Console.WriteLine("{0} and {1}", i, ht2[i]);
            }

            Console.WriteLine();

            //Removing an element:
            Console.WriteLine("Total number of elements present in h1: {0}", ht.Count);
            ht.Remove("A2");
            Console.WriteLine("Total number of elements present AFTER removal in h1: {0}", ht.Count);

            Console.WriteLine();

            //Checking the availability of key/value pair in a hashtable
            // - Contains() - check for a specific key
            // - ContainsKey() - also checks for a specific key
            // - ContainsValue() - checks for a specific value
            
            //Determine whether the given key is present or not using the Contains method
            Console.WriteLine(ht.Contains("A3"));
            Console.WriteLine(ht.Contains(12));
            Console.WriteLine();

            //Determine whether or not the value is present or not using the ContainsValue method
            Console.WriteLine(ht.ContainsValue("geeks"));
            Console.WriteLine(ht.ContainsValue("to"));
            Console.WriteLine();
            Console.WriteLine();

            //Updating a HashTable
            //In C#, the HashTable class does not provide a direct method to update the value of an existing key.
            //However, you can achieve the update by following these steps:
            //  1) Check if the key exists in the Hashtable using the ContainsKey method
            //  2) If the key exists, retrieve the current value using the key and store it in a variable
            //  3) Assign the new value to the key in the Hash table using the same key
            //  4) Optionally, remove the old key/value pair if needed

            //EXAMPLE:

            //Create a new dictionary
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            //Add some key/value pairs
            dictionary.Add("key1", "value1");
            dictionary.Add("key2", "value2");

            //Update the value of an existing key
            string keyToUpdate = "key1";
            if (dictionary.ContainsKey(keyToUpdate))
            {
                dictionary[keyToUpdate] = "updatedValue";
            }

            //Accessing the updated value
            string updatedValue;
            if (dictionary.TryGetValue(keyToUpdate, out updatedValue))
            {
                Console.WriteLine("Updated Value: " + updatedValue);
            }

            //Print all key/value pairs in the dictionary
            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
            }

            #endregion

            #region Video Tutorial #1

            //At a high level -> a HashTable is a key/value lookup
            //Can be any type of data structure
            //Hash function -> takes in a string, converts to an integer, and remaps the integer into an index into an array
            //                 string --> hashcode --> index

            //Collision: 2 different strings could have the same hashcode. There are an infinite number of strings but a finite number of hashcodes
            //           2 things with different hashcodes could end up with the same index
            //How do we deal with this?:
            //Chaining: When there are collisions, store them in a LinkedList
            //EX: Rather than this being an array of people, it would be an array of a LinkedList of people...
            //Keys need to be stored

            //class Hashtable
            //{
            //  LinkedList[]data <--Array of the LinkedList of the values
            //  boolean put (string key, person value) {
            //      int hashcode = getHashCode(key);
            //      int index = convertToIndex(hashCode);
            //      list.insert(key,value); <--check for duplicates
            //}

            //Runtime of a Hashtable: O(1) for a "good" hashtable (constant time)


            #endregion

            #region Video Tutorial #2

            //HashTable: data structure that allows for the very fast retrieval of data
            //          stores key/value pairs.

            //Hashing Algorithm: (aka Hash Function) Calculation applied to a key to transform it into a relatively small index number that corresponds to a position in the                    hashtable. (essentially, this is a memory address). Simpler Terms --> Calculation applied to a key to transform it into an address
            //                   For numeric keys, divide the key by the number of available addresses, n, and take the remainder.
            //                   address = key Mod n
            //                   For alphanumeric keys, divide the sum of ASCII codes in a key by the number of available addresses, n, and take the remainder
            //                   Folding method devides key into equal parts then adds the parts together
            //                      - The telephone number 01452 8345654, becomes 01 + 45 + 28 + 34 + 56 + 54 = 218
            //                      - Depending on the size of the table, may then divide by some constant and take the remainder

            //Collisions: When you apply a hashfunction to 2 different keys it generates the same index number for both. Both items cannot go into the same place
                //Open-Addressing: Resolving a collision by placing an item somewhere other than it's calculated address. Every location is open to any item.
                //                 Can use a variety of techniques to decide where to place an item that can't go where it should.
                //Linear-Probing: If the calculated address is occupied, then a linear search is used to find the next available slot. If it gets to the end of the array and                    still cannot find a space, it might cycle around to the beginning of the array and continue it's search from there
                //Larger the table = increased likelyhood of collisions
                //You can make the hashtable larger than needed in order to prevent collisions. (About 30% larger)
                //Load Factor: Total number of items stored / size of the array
                //             If the HashTable is dynamic, it could be made to resize automatically when the load factor reaches a certain load
                //

                //Closed-Addressing: (Chaining) (LinkedList)

            //Collision Resolution
            //Open Addressing
            //  - Linear Probing: If the calculated address is not available -> trying the next place, and the next, until an available space comes along
            //      Can lead to ---> Primary Clustering: Keys may bunch together inside of an array while large perportions of it remain open
            //      //WAYS TO REDUCE THE CHANCE OF PRIMARY CLUSTERING:
            //      - Plus 3 rehash (linear probing but with every 3rd space to avoid primary clustering)
            //      - Quadratic probing (failed attempts)^2: each time another failed attempt is made, the distance from the original point of collision grows rapidly
            //      - Double hashing - applies a 2nd hash function to they key when a collison occurs. The result of the 2nd hash function gives the number of positions             along from the point of the original collision to try next

            //Closed Addressing
            //Involves chaining items that have collided into a LinkedList or another suitable data structure

            //Objectives of Hash Function
            // - minimize collisions -> spend less time on collision resolution and data retrieval will be quicker
            // - give uniform distribution -> data should be spread as uniformly as possible throughout the HashTable
            // - easy to calculate
            // - should include a suitable method of solving any collisions that may occur

            //TO SUMMARIZE:
            //Hashtables are used to index large amounts of data
            //Address of each key is calculated using the key itself
            //Collisions are resolved with either open or closed addressing
            //Hashing is widely used in database indexing, compilers, caching, password auth, and more
            //Insertion, deletion, and retrieval occur in constant time (as long as there are no collisions)
            







            #endregion
        }
    }
}
