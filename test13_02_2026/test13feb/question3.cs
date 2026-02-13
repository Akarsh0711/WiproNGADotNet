using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test13Feb
{
    internal class Question3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 3: Reduce String by Removing K Consecutive Characters");
            
            Console.Write("Enter the string (str): ");
            string str = Console.ReadLine();

            Console.Write("Enter the integer (k): ");
            if (!int.TryParse(Console.ReadLine(), out int k) || k <= 1)
            {
                Console.WriteLine("Invalid K. K must be an integer > 1.");
                return;
            }

            string currentString = str;
            bool reductionPossible = true;

            while (reductionPossible)
            {
                reductionPossible = false;
                int n = currentString.Length;
                
                for (int i = 0; i <= n - k; i++)
                {
                    char firstChar = currentString[i];
                    bool matchFound = true;

                    for (int j = 1; j < k; j++)
                    {
                        if (currentString[i + j] != firstChar)
                        {
                            matchFound = false;
                            break;
                        }
                    }

                    if (matchFound)
                    {
                        currentString = currentString.Remove(i, k);
                        reductionPossible = true; 
                        
                        break; 
                    }
                }
            }

            Console.WriteLine($"Output: {currentString}");
            Console.WriteLine();
        }
    }
}
