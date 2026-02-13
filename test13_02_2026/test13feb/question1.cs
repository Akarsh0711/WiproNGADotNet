using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test13Feb
{
    internal class Question1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1: First Non-Repeating Character");
            Console.Write("Enter the string: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("String is empty.");
                return;
            }

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            char result = '$';
            foreach (char c in input)
            {
                if (charCounts[c] == 1)
                {
                    result = c;
                    break;
                }
            }

            Console.WriteLine($"Output: '{result}'");

            if (result != '$')
            {
                Console.WriteLine($"Explanation: '{result}' is the first character in the string which does not repeat.");
            }
            else
            {
                Console.WriteLine("Explanation: All the characters in the given string are repeating.");
            }
            Console.WriteLine();
        }
    }
}
