using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.FirstLib
{
    /// <summary>
    /// Demonstrates various access modifiers in C#.
    /// </summary>
    public class AccessControlSource
    {
        private string _privateMessage = "Welcome (Private)";
        protected string _protectedMessage = "Hello (Protected)";
        internal string _internalMessage = "Interns (Internal)";
        protected internal string _internalProtectedMessage = "IpAddress (Internal Protected)";
        public string _publicMessage = "Wipro (Public)";

        /// <summary>
        /// Displays the values of all fields.
        /// </summary>
        public void DisplayAccessLevels()
        {
            Console.WriteLine(_privateMessage);
            Console.WriteLine(_publicMessage);
            Console.WriteLine(_internalMessage);
            Console.WriteLine(_internalProtectedMessage);
            Console.WriteLine(_protectedMessage);
        }
    }
}
