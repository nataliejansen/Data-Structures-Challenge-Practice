using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Challenges
{
    internal class CharacterCount
    {
        static void Main(string[] args)
        {
            //Write code to create a function that accepts a string and returns an object
            //containing the number of times each character appears in the string:

            //EXAMPLE 1: "She sells sea shells by the sea shore";
            //Expected Output: S=8; H=4; E=7; " "=7; L=4; A=2; B=1; Y=1; T=1; O=1; R=1;

            string input = "She sells sea shells by the sea shore";
            input = input.ToLower();
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach(var character in input)
            {
                
                    if (!charCount.ContainsKey(character))
                    {
                        charCount.Add(character, 1);
                    }
                    else
                    {
                        charCount[character]++;
                    }

            }
            foreach (var character in charCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
            Console.WriteLine();

            //EXAMPLE 2: "Peter Piper picked a pack of pickled peppers"
            //EXPECTED OUTPUT: P=9; E=7; T=1; R=3; " "=7; I=3; C=3; K=3; D=2; A=2; O=1; F=1; L=1; S=1;
            string phrase = "Peter Piper picked a pack of pickled peppers";
            phrase = phrase.ToLower();
            Dictionary<char, int> cc = new Dictionary<char, int>();
            foreach (var ch in phrase)
            {
                if (!cc.ContainsKey(ch))
                {
                    cc.Add(ch, 1);
                }
                else
                {
                    cc[ch]++;
                }
            }
            foreach (var ch in cc)
            {
                Console.WriteLine("{0} - {1}", ch.Key, ch.Value);
            }






        }
    }
}
