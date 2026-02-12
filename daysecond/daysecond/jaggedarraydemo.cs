using System;

namespace daysecond
{
    internal class jaggedarraydemo
    {
        static void Main()
        {

            int[] row1 = new int[] { 11, 12, 13, 14 };
            int[] row2 = new int[] { 5, 6, 7, 8 };
            int[] row3 = new int[] { 18, 19, 12, 22, 12 };
            

            int[][] jaggedArr = new int[3][];

            jaggedArr[0] = row1;
            jaggedArr[1] = row2;
            jaggedArr[2] = row3;

            Console.WriteLine("Displaying Jagged Array Content:");

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                foreach (int val in jaggedArr[i])
                {
                    Console.Write(val + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
