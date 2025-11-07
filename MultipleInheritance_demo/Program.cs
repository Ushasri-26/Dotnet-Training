using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.GetProductInfo();
            customer.GetReviews();
            Console.WriteLine("\n Product Details and Customer Reviews\n");
            customer.DisplayProductInfo();
            customer.DisplayReviews();
        }
    }
}
