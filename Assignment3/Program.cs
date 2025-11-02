using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double purchase_amount, finalamount, discount;
            Console.Write($"Enter purchase amount:");
            purchase_amount = Convert.ToDouble(Console.ReadLine());
            if (purchase_amount < 1000)
                discount = 0;
            else if (purchase_amount >= 1000 && purchase_amount <= 5000)
                discount = purchase_amount * 0.1;
            else
                discount = purchase_amount * 0.2;
            finalamount = purchase_amount-discount;
      
            Console.WriteLine($"Final amount after discount: Rs.{finalamount}");
            Console.ReadLine();
  
        }
    }
}
