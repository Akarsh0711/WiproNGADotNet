using System;

namespace daysecond
{
    internal class jaggedarraystring
    {
        static void Main()
        {
            string[] module1 = new string[] { "MileStone-1", "Mcq-1", "Labs:1-10" };
            string[] module2 = new string[] { "MileStone-2", "Labs:11-15" };
            string[] module3 = new string[] { "Project-1", "Virtual Labs", "Mcq-2" };
            string[] module4 = new string[] { "Capstone Project", "Final MCQ" };
            
            string[][] courseDynamics = new string[4][];

            courseDynamics[0] = module1;
            courseDynamics[1] = module2;
            courseDynamics[2] = module3;
            courseDynamics[3] = module4;

            Console.WriteLine("Course Modules required for completion:");
            for(int i = 0; i < courseDynamics.Length; i++)
            {
                foreach(string item in courseDynamics[i])
                {
                    Console.Write(item + "    ");
                }
                Console.WriteLine();
            }
        }
    }
}
