using System;

namespace homework
{
    internal class homework2
    {
        static void Main()
        {
            string sourceText = "Welcome All liril is soap Malayalam is language madam is heading company";
            Console.WriteLine("Input String: " + sourceText);

            string[] distinctWords = sourceText.Split(' ');
            int palindromeCount = 0;
            
            foreach (string word in distinctWords)
            { 
                string normalizedWord = word.ToLower();
                char[] letters = normalizedWord.ToCharArray();
                Array.Reverse(letters);
                string reversedWord = new string(letters);


                if (normalizedWord.Equals(reversedWord) && normalizedWord.Length > 1)
                {
                    palindromeCount++;
                }
            }
            Console.WriteLine("Count of Palindrome words found: " + palindromeCount);
        }
    }
}
