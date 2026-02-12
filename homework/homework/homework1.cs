using System;
using System.Linq;

namespace homework
{
    internal class homework1
    {
        public void ReverseAlternateWords()
        {
            string inputText = "Welcome to C# programming from Wipro Training ";
            Console.WriteLine("Original: " + inputText);

            string[] splitText = inputText.Split(' ');
            
            Console.WriteLine("Processing Alternate Reversal...");
            for (int i = 0; i < splitText.Length; i++)
            {

                if (i % 2 == 1)
                {
                    char[] charArray = splitText[i].ToCharArray();
                    Array.Reverse(charArray);
                    splitText[i] = new string(charArray);
                }
            }

            string finalResult = string.Join(" ", splitText);
            Console.WriteLine(finalResult);
        }
        static void Main()
        {
            homework1 assignment = new homework1();
            assignment.ReverseAlternateWords();
        }
    }
}
