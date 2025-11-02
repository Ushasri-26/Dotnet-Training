using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;
            Console.Write("Enter password:");
            password = Console.ReadLine();
            if (password.Length < 6)
                Console.WriteLine($"password strength: Weak");
            else if (password.Length >= 6 && password.Length <= 10)
                Console.WriteLine($"password strength: Medium");
            else
                Console.WriteLine($"password strength: Strong");
            Console.ReadLine();
        }
    }
}
