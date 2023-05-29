using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        static bool IsAnagram(string a, string b)
        {

            // Convert the strings to lowercase

            a = a.ToLower();
            b = b.ToLower();
            // Check if the lengths of the strings are equal
            if (a.Length != b.Length)
            {
                return false;
            }
            // Create dictionaries to store character frequencies
            Dictionary<char, int> freqA = new Dictionary<char, int>();
            Dictionary<char, int> freqB = new Dictionary<char, int>();
            // Count the frequency of each character in string a
            foreach (char c in a)
            {
                if (freqA.ContainsKey(c))
                {
                    freqA[c]++;
                }
                else
                {
                    freqA[c] = 1;
                }
            }
            // Count the frequency of each character in string b
            foreach (char c in b)
            {
                if (freqB.ContainsKey(c))
                {
                    freqB[c]++;
                }
                else
                {
                    freqB[c] = 1;
                }
            }
            // Compare the character frequencies
            foreach (KeyValuePair<char, int> kvp in freqA)
            {
                char key = kvp.Key;
                int value = kvp.Value;
                // If a character in a is not present in b or
                // if the frequencies are different, they are not anagrams
                if (!freqB.ContainsKey(key) || freqB[key] != value)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(String[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (IsAnagram(a, b))
            {

                Console.WriteLine("Anagrams");
            }
            else
            {
                Console.WriteLine("Not Anagrams");
            }

        }
    }
}






















































































































































