using System;

namespace dayfirst
{
    internal class personselector
    {
        public void SelectPerson(int selection)
        {
            if(selection == 1)
            {
                Console.WriteLine("I am Pranav.");
            }
            else if (selection == 2)
            {
                Console.WriteLine("I am Raja.");
            }
            else if (selection == 3)
            {
                Console.WriteLine("I am Rahul.");
            }
            else if (selection == 4)
            {
                Console.WriteLine("I am Virat.");
            }
            else
            {
                Console.WriteLine("Invalid Selection");
            }
        }
        static void Main()
        {
            int userChoice;
            Console.WriteLine("Enter Choice:");
            userChoice = Convert.ToInt32(Console.ReadLine());

            personselector selector = new personselector();
            selector.SelectPerson(userChoice);
        }
    }
}
