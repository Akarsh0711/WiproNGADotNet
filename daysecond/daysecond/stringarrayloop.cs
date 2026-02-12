using System;

namespace daysecond
{
    internal class stringarrayloop
    {
        public void ShowNames()
        {
            string[] studentNames = new string[] 
            { 
                "Tushar","Pranav","Aman","Abhishek","Aryan","Harsh","Eshwar","Neerav"
            };
            foreach(string name in studentNames)
            {
                Console.WriteLine(name);
            }
        }
        static void Main()
        {
            stringarrayloop demo = new stringarrayloop();
            demo.ShowNames();
        }
    }
}
