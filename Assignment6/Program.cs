using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age,showtime;
            double ticketPrice;
            Console.Write("Enter age:");
            age=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter show time (24-hr format):");
            showtime= Convert.ToInt32(Console.ReadLine());

            if (age < 12)
                ticketPrice = 150;
            else if (age >= 12 && showtime < 18)
                ticketPrice = 250;
            else
                ticketPrice = 300;
            Console.Write($"Ticket price: Rs.{ticketPrice}");
            Console.ReadLine();
        }
    }
}
