using System;

namespace daythird
{
    internal class overloadquizdoubleobj
    {
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
            overloadquizdoubleobj quiz = new overloadquizdoubleobj();

            quiz.Display(752); 
        }
    }
}
