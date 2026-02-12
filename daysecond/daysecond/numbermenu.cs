using System;

namespace daysecond
{

    internal class numbermenu
    {
        public void CheckPerfect(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Perfect Number...");
            }
            else
            {
                Console.WriteLine("Not Perfect Number...");
            }
        }

        public void CheckPrime(int n)
        {
            bool isPrime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime Number...");
            }
            else
            {
                Console.WriteLine("Not-Prime Number...");
            }
        }

        public void CheckEvenOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Even Number...");
            }
            else
            {
                Console.WriteLine("Odd Number...");
            }
        }

        public void ShowMenu(int n)
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Even-Odd");
                Console.WriteLine("2. Prime check");
                Console.WriteLine("3. Perfect check");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter Choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckEvenOdd(n);
                        break;
                    case 2:
                        CheckPrime(n);
                        break;
                    case 3:
                        CheckPerfect(n);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            } while (choice != 4);
        }

        static void Main()
        {
            int inputNum;
            Console.WriteLine("Enter Number to Analyze:");
            inputNum = Convert.ToInt32(Console.ReadLine());
            
            numbermenu menu = new numbermenu();
            menu.ShowMenu(inputNum);
        }
    }
}
