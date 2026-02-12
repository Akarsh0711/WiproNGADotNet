using System;

namespace dayfirst
{
    internal class program3
    {
        static void Main()
        {
            string studentName;
            string cityName;
            string companyName;

            Console.WriteLine("Enter Student Name:");
            studentName = Console.ReadLine();

            Console.WriteLine("Enter City:");
            cityName = Console.ReadLine();

            Console.WriteLine("Enter Company:");
            companyName = Console.ReadLine();

            Console.WriteLine("-------------------------");
            Console.WriteLine("Name    : " + studentName);
            Console.WriteLine("City    : " + cityName);
            Console.WriteLine("Company : " + companyName);
        }
    }
}
