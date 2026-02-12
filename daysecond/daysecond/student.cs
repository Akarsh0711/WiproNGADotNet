using System;

namespace daysecond
{
    internal class student
    {
        public int studentId;
        public string studentName;
        public string city;
        
        public void DisplayStudentInfo()
        {
            Console.Write($"ID: {studentId} | Name: {studentName} | City: {city}");
        }
    }
}
