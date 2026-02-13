using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test13Feb
{
    internal class Question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 2: Palindrome Sentence Check");
            Console.WriteLine("Enter the sentence:");
            string s = Console.ReadLine();
            
            if (s == null) s = "";

            string cleanString = "";

            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleanString += char.ToLower(c);
                }
            }

            bool isPalindrome = true;
            int length = cleanString.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (cleanString[i] != cleanString[length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine($"Output: {isPalindrome.ToString().ToLower()}");
            
            if (isPalindrome)
            {
                Console.WriteLine($"Explanation: The processed string \"{cleanString}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"Explanation: The processed string \"{cleanString}\" is NOT a palindrome.");
            }
            Console.WriteLine();
        }
    }
}
