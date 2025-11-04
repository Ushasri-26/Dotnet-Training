using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery
{
    internal class grocery
    {
        public void CalculateDiscount(double total, out double discount, out double finalAmount)
        {
            double discountPercent = 0;

            if (total > 5000)
                discountPercent = 20;
            else if (total >= 2000 && total <= 4999)
                discountPercent = 10;
            else if (total >= 1000 && total <= 1999)
                discountPercent = 5;
            else
                discountPercent = 0;

            discount = (discountPercent / 100) * total;
            finalAmount = total - discount;
        }
        public void DisplayBill(string[] itemNames, int[] quantities, double[] prices, double[] totals, double discount, double finalAmount, double grandTotal)
        {
            Console.WriteLine("\n===== BILL DETAILS =====");
            Console.WriteLine("Item Name\tQuantity\tPrice\tTotal");
            Console.WriteLine("---------------------------------------------------");

            for (int i = 0; i < itemNames.Length; i++)
            {
                Console.WriteLine($"{itemNames[i]}\t\t{quantities[i]}\t\t{prices[i]}\t{totals[i]}");
            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Grand Total:\t\t\t\t{grandTotal}");
            if (discount > 0)
                Console.WriteLine($"Discount Applied:\t\t\t{discount}");
            else
                Console.WriteLine($"Discount Applied:\t\t\tNo Discount");
            Console.WriteLine($"Final Amount to Pay:\t\t\t{finalAmount}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\nThank you for shopping with us!");
        }

    }
}
