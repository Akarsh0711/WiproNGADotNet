using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;


[assembly: CLSCompliant(true)]
namespace ReflectionExamples
{

    public class P6
    {
        public void HelloWorld()
        {
        }
        
        public void HELLOWORLD()
        {
        }

        static void Main()
        {

            Console.WriteLine("Welcome to Reflection...");
        }
    }
}
