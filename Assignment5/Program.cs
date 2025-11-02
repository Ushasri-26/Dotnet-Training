using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double billAmount, finalBill, amountPerPerson;
            int people;
            Console.Write("Enter bill amount: Rs.");
            billAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter total people: ");
            people = Convert.ToInt32(Console.ReadLine());
            finalBill = billAmount;
            if (billAmount>1000)
            {
                double gst = billAmount * 0.05;
                double serviceCharge = billAmount * 0.10;
                finalBill = billAmount + gst + serviceCharge;
            }
            amountPerPerson = finalBill / people;
            Console.WriteLine($"Each person should pay: Rs.{amountPerPerson}");
            Console.ReadLine();
        }
    }
}
