using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShippingCalculator calc = new ShippingCalculator();

            decimal cost1 = calc.CalculateStandard(3, "CITY");
            decimal cost2 = calc.CalculateExpress(2, "REMOTE");
            decimal cost3 = calc.CalculateInternational(6, "ANY");

            Console.WriteLine($"{calc.Label("STANDARD")} Rs.{cost1}");
            Console.WriteLine($"{calc.Label("EXPRESS")} Rs.{cost2}");
            Console.WriteLine($"{calc.Label("INTL")} Rs.{cost3}");

            Console.ReadLine();
        }
    }
}
