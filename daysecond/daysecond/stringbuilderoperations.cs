using System;
using System.Text;

namespace daysecond
{
    internal class stringbuilderoperations
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Welcome to C# Programming...");
            Console.WriteLine("Original: " + sb);
            
            sb.Insert(5, "Ritwak");
            Console.WriteLine("After Insert: " + sb);
            
            sb.Remove(5, 6);
            Console.WriteLine("After Remove: " + sb);
            
            sb.Append(" Tushar");
            Console.WriteLine("After Append: " + sb);
        }
    }
}
