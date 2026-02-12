using System;

namespace daysecond
{

    internal class arraydeclaration
    {
        public void ShowArray()
        {
            int[] data = new int[] { 12, 66, 31, 66, 23, 122 };
            
            foreach(int val in data)
            {
                Console.WriteLine(val);
            }
        }
        static void Main()
        {
            arraydeclaration demo = new arraydeclaration();
            demo.ShowArray();
        }
    }
}
