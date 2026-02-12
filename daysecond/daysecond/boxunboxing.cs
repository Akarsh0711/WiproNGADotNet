using System;

namespace daysecond
{
    internal class boxunboxing
    {
        public void DemonstrateCasting(object obj)
        {
            if (obj is Int32)
            {
                int intVal = (Int32)obj;
                Console.WriteLine($"Integer Unboxed: {intVal}");
            }
            if (obj is String)
            {
                string strVal = (String)obj;
                Console.WriteLine($"String Unboxed: {strVal}");
            }
            if (obj is Double)
            {
                double dblVal = (Double)obj;
                Console.WriteLine($"Double Unboxed: {dblVal}");
            }
        }
        static void Main()
        {
            int num = 12;
            string text = "Hello";
            double decimalNum = 12.5;
            
            boxunboxing demo = new boxunboxing();
            demo.DemonstrateCasting(num);
            demo.DemonstrateCasting(text);
            demo.DemonstrateCasting(decimalNum);
        }
    }
}
