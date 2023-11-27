using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    internal class Dictionary
    {
        static void Main(string[] args)
        {
            //DICTIONARIES
            //Dictionary is a generic collection which is generally used to store key/value pairs. (This is similar to a non-generic hashtable)
            //Advantage - it is a generic type.

            //IMPORTANT POINTS:
            //the Dictionary class implements the
            // IDictionary<TKey, TValue> Interface
            // IReadOnlyCollection<KeyValuePair<TKey, TValue>> Interface
            // IReadOnlyDictionary<TKey, TValue> Interface
            // IDictionary Interface
            //In Dictionary, the key cannot be null, but the value can be.
            //The key must be unique. Duplicate keys are not allowed. If you try and use a duplicate key then the compiler will throw an exception.
            //You can only store the same types of elements
            //The capacity of the Dictionary is the number of elements that Dictionary can hold

            //How to create a Dictionary?
            // Dictionary class has 7 constructors which are used to create the Dictionary, here we only use Dictionary<TKey, TValue>() constructor.
            // Dictionary<TKey, TValue>(): This constructor is used to create an instance of the Dictionary<TKey, TValue> class that is empty,
            // has the default initial capacity, and uses the default equality comparer for the key type as follows:

            // Creating a dictionary
            // using Dictionary<TKey,TValue> class
            Dictionary<int, string> My_dict1 =
                           new Dictionary<int, string>();

            // Adding key/value pairs 
            // in the Dictionary
            // Using Add() method
            My_dict1.Add(1123, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(1125, "GeeksforGeeks");

            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();

            // Creating another dictionary
            // using Dictionary<TKey,TValue> class
            // adding key/value pairs without
            // using Add method
            Dictionary<string, string> My_dict2 =
                    new Dictionary<string, string>(){
                                  {"a.1", "Dog"},
                                  {"a.2", "Cat"},
                                {"a.3", "Pig"} };

            foreach (KeyValuePair<string, string> ele2 in My_dict2)
            {
                Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
            }

            //Remove elements from the Dictionary (can use Clear() to remove all, can use Remove() to remove the value with the specified key from the Dictionary)
            Console.WriteLine();
            My_dict1.Remove(1123);

            foreach (KeyValuePair<int, string> i in My_dict1)
            {
                Console.WriteLine("{0} and {1}", i.Key, i.Value);
            }

            //How to check the availability of elements in the Dictionary?
            // ContainsKey - This method is used to check whether the Dictionary<TKey, TValue> contains the specified key
            // ContainsValue - This method is used to check whether the Dictionary<TKey, TValue> contains a specific value

            //EXAMPLE:
            Console.WriteLine();
            My_dict1.Add(1123, "Welcome");

            //Using ContainsKey() method to check if the specifed key is present or not
            if (My_dict1.ContainsKey(1122) == true)
            {
                Console.WriteLine("Key has been found!");
            }
            else
            {
                Console.WriteLine("Key has NOT been found!");
            }

            //Using ContainsValue() method to check if the specified value is present or not
            if (My_dict1.ContainsValue("GeeksforGeeks") == true)
            {
                Console.WriteLine("Value is found!");
            }
            else
            {
                Console.WriteLine("Value has NOT been found");
            }

            #region Video Tutorial Notes

            //Option for non-numerical indexes
            //flexibility when it comes to making keys
            //speed which comes with hash table implementation

            //Dictionaries are implemented with a HashTable
            //The keys in the key/value pairs are stored in memory IN these hash tables at indexes(reminder these are determined by the hash function)

            //Dictionary - an abstract Data Structure which stores data in the form of key/value pairs
            //           - Example: Key = Social Security Number, Value = Human ----> Dictionary = All humans

            //Basic Info
            //We index dictionaries using keys instead of a numerical index
            //The keys in a key/value pair can pretty much be any primitive data type (int, string, char, etc)



            //Dictionary Properties

            //There can be duplicates of values, just not keys

            //Important Restrictions
            // - every key can only appear once within the dictionary
            // - each key can only have one value

            //Hash Tables / Hash Functions

            //Examples

            //Time Complexity Equations
            //We generally measure a data structure based on it's worst-case scenario




            #endregion


        }

    }
    
}
