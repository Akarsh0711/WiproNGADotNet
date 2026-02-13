using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.Collections
{
    internal class HashtableDemoOne
    {
        static void Main()
        {
            Hashtable dataTable = new Hashtable();
            dataTable.Add(1, "Item A");
            dataTable.Add(2, "Item B");
            dataTable.Add(3, "Item C");
            dataTable.Add(4, "Item D");
            dataTable.Add(5, "Item E");

            int searchKey;
            Console.WriteLine("Enter Key  ");
            searchKey = Convert.ToInt32(Console.ReadLine());
            string result = (string)dataTable[searchKey];
            
            if (result == null)
            {
                Console.WriteLine("Key Not Found");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
