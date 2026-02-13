using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.Collections
{
    internal class ArrayListDemo
    {
        static void Main()
        {
            ArrayList namesList = new ArrayList();
            namesList.Add("Alice");
            namesList.Add("Bob");
            namesList.Add("Charlie");
            namesList.Add("David");
            namesList.Add("Eve");
            namesList.Add("Frank");

            Console.WriteLine("ArrayList Elements:");
            foreach(object obj in namesList)
            {
                Console.WriteLine(obj);
            }

            namesList.Insert(3, "Grace");
            Console.WriteLine("ArrayList after Insertion:");
            foreach (object obj in namesList)
            {
                Console.WriteLine(obj);
            }

            namesList.RemoveAt(3);
            Console.WriteLine("Removing Element at 3rd Position:");
            foreach (object obj in namesList)
            {
                Console.WriteLine(obj);
            }

            namesList.Remove("Charlie");
            Console.WriteLine("Removing Element by Object Name (Charlie):");
            foreach (object obj in namesList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
