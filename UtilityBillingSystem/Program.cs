using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityBillingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Welcome to Online Utility Billing System =====");
            Console.Write("Enter number of customers:");
            int count=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter details for Customer #{i}");
                UtilityBill bill = new UtilityBill();
                Console.Write("Customer ID:");
                bill.CustomerID=Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Customer Name:");
                bill.CustomerName = Console.ReadLine();
                Console.WriteLine("Enter monthly usage readings(in units):");
                string line = Console.ReadLine();

                string[] parts = line.Split(' ');
                double r1 = Convert.ToDouble(parts[0]);
                double r2 = Convert.ToDouble(parts[1]);
                double r3 = Convert.ToDouble(parts[2]);

                double usage = bill.GetTotalUsage(r1, r2, r3);
                bill.CalculateBill(usage, out double total, out double tax, out double netPay);
                Console.WriteLine();
                Console.WriteLine("\n==========Utility Bill==========");
                Console.WriteLine("Customer ID: " + bill.CustomerID);
                Console.WriteLine("Customer Name: " + bill.CustomerName);
                Console.WriteLine("Service Charge: " + UtilityBill.ServiceCharge.ToString("F2"));
                Console.WriteLine("Total Usage    : Rs." + total.ToString("F2"));
                Console.WriteLine("Tax Applied    : Rs." + tax.ToString("F2"));
                Console.WriteLine("Net Payable    : Rs." + netPay.ToString("F2"));
                Console.WriteLine("=====================================");
            }
            Console.WriteLine() ;
            Console.WriteLine("\nAll customers bill processed successfully!");
            Console.ReadLine();
        }

    }
}
