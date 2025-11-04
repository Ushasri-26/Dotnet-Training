using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyApp_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter distance (KM): ");
            decimal.TryParse(Console.ReadLine(), out _);

            Console.Write("Enter distance correctly (KM): ");
            decimal distance = Convert.ToDecimal(Console.ReadLine());

            Customer customer = new Customer("Aarav Sharma", "98765-43210", 170);
            Vehicle vehicle = new Vehicle("Sedan", 100, 15);
            string[] addOns = { "priority-pickup", "fast-tag", "extra-luggage" };

            Ride ride = new Ride(customer, vehicle, distance, DateTime.Now);

            ride.ComputeBill(out decimal subtotal, out decimal gst, out decimal total, addOns);

            decimal totalBeforeCoupon = total;
            decimal couponAmount = 50;

            Pricing.ApplyCoupon_ByRef(ref total, couponAmount);
            Pricing.RedeemLoyalty(ref customer.LoyaltyPoints, ref total);

            decimal valueDemo = Pricing.TryApplyCoupon_ByValue(totalBeforeCoupon, 50);

            Console.WriteLine("\n========== RideEasy Invoice ===========");
            Console.WriteLine($"Date: {DateTime.Now:dd-MMM-yyyy (ddd)}");
            Console.WriteLine($"Customer: {customer.Name} ({customer.Mobile})");
            Console.WriteLine($"Vehicle: {vehicle.Type}");
            Console.WriteLine($"Distance: {distance} km");
            Console.WriteLine("Add-Ons: " + string.Join(", ", addOns));
            Console.WriteLine("---------------------------------------");

            Console.WriteLine($"Subtotal:\t  Rs. {subtotal:F2}");
            Console.WriteLine($"GST (18%):\t  Rs. {gst:F2}");
            Console.WriteLine($"Total (before): Rs. {totalBeforeCoupon:F2}");

            Console.WriteLine($"Coupon (by REF):\t- applied Rs.{couponAmount:F2}");
            Console.WriteLine("Loyalty redeem:\t- applied up to available points");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine($"Final Payable:\t  Rs. {total:F2}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"(Demonstration) Call-by-VALUE coupon attempt did NOT change total: ₹{totalBeforeCoupon:F2}");
            Console.WriteLine($"Remaining Loyalty Points: {customer.LoyaltyPoints}");
            Console.WriteLine("=======================================\n");
        }

        }
    }

