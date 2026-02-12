using System;
using System.Text;

namespace daysecond
{
    internal class stringbuilderdemo
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Student List:\n");
            
            sb.AppendLine("Neerav");
            sb.AppendLine("Uday");
            sb.AppendLine("Aman");
            sb.AppendLine("Vinay");
            sb.AppendLine("Tushar");
            
            Console.WriteLine(sb);
        }
    }
}
