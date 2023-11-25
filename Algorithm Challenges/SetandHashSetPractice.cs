using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Challenges
{
    internal class SetandHashSetPractice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SETS/HASHSETS:");
            //HashSet: An ordered collection containing unique elements. Uses hash based implementations
            //HashSet class: Based on the model of mathematical sets. Provides high performace set operations
            //WHY??:
            //HashSets DO NOT store duplicates
            //Are faster than arrays. 

            //HashSet<string> hobbies = new HashSet<string>();
            //hobbies.Add("football"); //each will generate it's own hash value
            //hobbies.Add("tennis");
            //hobbies.Add("golf");
            //hobbies.Add("hiking");
            //hobbies.Add("tennis"); //This will not be added since it is a duplicate

            //List<string> hobbiesList = new List<string>();
            //hobbiesList.Add("football"); 
            //hobbiesList.Add("tennis");
            //hobbiesList.Add("golf");
            //hobbiesList.Add("hiking");
            //hobbiesList.Add("tennis");
            //hobbiesList.Add("hiking");
            //hobbiesList.Add("football");

            ////Create a HashSet from a list
            //HashSet<string> uniqueHobbies = new HashSet<string>(hobbiesList);

            //uniqueHobbies.Contains("golf"); //Can be used for seach

            HashSet<string> hobbiesA = new HashSet<string>();
            hobbiesA.Add("football");
            hobbiesA.Add("tennis");
            hobbiesA.Add("golf");

            HashSet<string> hobbiesB = new HashSet<string>();
            hobbiesB.Add("hiking");
            hobbiesB.Add("golf");

            //Join the 2 HashSets together (Could be info from 2 different databases for example)

            /*hobbiesA.UnionWith(hobbiesB);*/ //This will now contain 4 elements since golf would be a duplicate

            //Intersections with HashSets

            hobbiesA.IntersectWith(hobbiesB); //This would show the duplicates in each HashSet

            //string[] hobbiesArray = { "football", "tennis", "golf", "hiking", "tennis" }; 
            //saves by index--tennis would be added twice even though it's a duplicate
            
            //EXAMPLE

            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                evenNumbers.Add(i * 2);
                oddNumbers.Add((i * 2) + 1);
            }
            Console.WriteLine("Even Numbers: ");
            foreach (var x in evenNumbers)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Odd Numbers: ");
            foreach (var y in oddNumbers)
            {
                Console.WriteLine(y);
            }

            //ANOTHER EXAMPLE

            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            numbers.UnionWith(oddNumbers);
            Console.WriteLine("All Numbers:");
            foreach (var j in numbers)
            {
                Console.WriteLine(j);
            }







        }
    }
}
