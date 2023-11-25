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
        }
    }
}
