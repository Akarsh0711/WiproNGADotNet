using System;

namespace daythird
{
    internal class overloadquizlongdouble
    {
        public void Display(long val)
        {
            Console.WriteLine("Called Display(long): " + val);
        }
        public void Display(double val)
        {
            Console.WriteLine("Called Display(double): " + val);
        }

        public void Display(object val)
        {
            Console.WriteLine("Called Display(object): " + val);
        }
        
        static void Main()
        {
            overloadquizlongdouble quiz = new overloadquizlongdouble();

            quiz.Display(526);
        }
    }
}
