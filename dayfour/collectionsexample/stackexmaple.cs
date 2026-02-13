using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.Collections
{
    internal class StackDemo
    {
        static void Main()
        {
            Stack historyStack = new Stack();
            historyStack.Push("Page 1");
            historyStack.Push("Page 2");
            historyStack.Push("Page 3");
            historyStack.Push("Page 4");
            historyStack.Push("Page 5");

            Console.WriteLine("Stack Data:");
            foreach(object page in historyStack)
            {
                Console.WriteLine(page);
            }
            historyStack.Pop();
            historyStack.Pop();
            Console.WriteLine("Stack Data After Pop Operation:");
            foreach (object page in historyStack)
            {
                Console.WriteLine(page);
            }
        }
    }
}
