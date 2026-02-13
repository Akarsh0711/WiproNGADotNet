using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.Collections
{
    internal class QueueDemo
    {
        static void Main()
        {
            Queue tasksQueue = new Queue();
            tasksQueue.Enqueue("Task 1");
            tasksQueue.Enqueue("Task 2");
            tasksQueue.Enqueue("Task 3");
            tasksQueue.Enqueue("Task 4");
            tasksQueue.Enqueue("Task 5");

            Console.WriteLine("Queue Data:");
            foreach(object task in tasksQueue)
            {
                Console.WriteLine(task);
            }
        }
    }
}
