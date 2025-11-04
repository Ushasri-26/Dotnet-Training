using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyApp_Assignment
{
    static class Pricing
    {
        public static decimal CalculateGST(decimal amount)
        {
            return amount * 0.18M;
        }
        public static bool TryGetWeekendSurcharge(DateTime rideDate,out decimal percent)
        {
            if (rideDate.DayOfWeek == DayOfWeek.Saturday || rideDate.DayOfWeek == DayOfWeek.Sunday)
            {
                percent = 0.10M;
                return true;
            }
            percent = 0;
            return false;
        }
        public static decimal AddOnsCost(params string[] addOns)
        {
            decimal cost = 0;
            foreach (var add in addOns)
            {
                if (add == "child-seat") cost += 50;
                else if (add == "fast-tag") cost += 80;
                else if (add == "priority-pickup") cost += 100;
                else if (add == "extra-luggage") cost += 120;
            }
            return cost;
        }

        public static decimal TryApplyCoupon_ByValue(decimal total, decimal couponAmount)
        {
            return total - couponAmount;
        }

        public static void ApplyCoupon_ByRef(ref decimal total, decimal couponAmount)
        {
            total -= couponAmount;
        }

        public static void RedeemLoyalty(ref int points, ref decimal total)
        {
            decimal discount = points;
            if (discount > total) discount = total;

            total -= discount;
            points = 0;

        }
    }
}
