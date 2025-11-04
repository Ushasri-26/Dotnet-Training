using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            grocery grocery = new grocery();
            Console.WriteLine("===== SMART GROCERY BILLING SYSTEM =====");
            Console.Write("Enter number of items: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] itemNames = new string[n];
            int[] quantities = new int[n];
            double[] prices = new double[n];
            double[] totals = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for Item {i + 1}:");
                Console.Write("Item Name: ");
                itemNames[i] = Console.ReadLine();

                Console.Write("Quantity: ");
                quantities[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Price per Unit : ");
                prices[i] = Convert.ToDouble(Console.ReadLine());

                totals[i] = quantities[i] * prices[i];
            }
            double grandTotal = 0;
            for (int i = 0; i < n; i++)
            {
                grandTotal += totals[i];
            }
            grocery.CalculateDiscount(grandTotal, out double discount, out double finalAmount);
            grocery.DisplayBill(itemNames, quantities, prices, totals, discount, finalAmount, grandTotal);
            Console.ReadLine();
        }
    }
}
    

