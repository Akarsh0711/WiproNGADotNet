using System;

namespace daysecond
{
    internal class stringoperations
    {
        static void Main()
        {
            string msg = "Welcome to C# Programming...";
            Console.WriteLine(msg);
            
            Console.WriteLine("Length: " + msg.Length);
            Console.WriteLine("Index of 'e': " + msg.IndexOf("e"));
            
            string s1 = "Aman";
            string s2 = "Neerav";
            string s3 = "Aman";
            
            Console.WriteLine("s1 equals s2: " + s1.Equals(s2));
            Console.WriteLine("s1 equals s3: " + s1.Equals(s3));
            
            Console.WriteLine("Compare s1 to s2: " + s1.CompareTo(s2));
            Console.WriteLine("Compare s2 to s3: " + s2.CompareTo(s3));
            Console.WriteLine("Compare s1 to s3: " + s1.CompareTo(s3));
            
            Console.WriteLine("Substring (5,10): " + msg.Substring(5,10));
            Console.WriteLine("Replace C# with ASP.NET: " + msg.Replace("C#","ASP.NET"));
            
            string studentList = "Kishore Vijay Aman Irfan Adhiraj Rithwik Akarsh Pranav";
            string[] names = studentList.Split(' ');
            
            Console.WriteLine("--- Split Names ---");
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            
            string part1 = "Hello";
            string part2 = " World...!";
            string combined = string.Concat(part1, part2);
            Console.WriteLine(combined);
        }
    }
}
