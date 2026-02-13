using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.Collections
{
    internal class HashtableAuthenticationDemo
    {
        static void Main()
        {
            Hashtable credentials = new Hashtable();
            credentials.Add("user1", "pass1");
            credentials.Add("user2", "pass2");
            credentials.Add("admin", "admin123");
            credentials.Add("guest", "guest123");
            
            string username, password;
            Console.WriteLine("Enter UserName and Password ");
            username = Console.ReadLine();
            password = Console.ReadLine();
            
            string storedPassword =(string) credentials[username];
            if (storedPassword == null)
            {
                Console.WriteLine("User Name Not Found...");
                return;
            } 
            if (storedPassword.Equals(password))
            {
                Console.WriteLine("Correct Credentials...");
            }
            else
            {
                Console.WriteLine("Invalid Credentials...");
            }
        }
    }
}
