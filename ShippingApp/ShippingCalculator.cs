using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingApp
{
    public class ShippingCalculator
    {
        public decimal CalculateStandard(decimal weight, string zone)
        {
            decimal cost = 50 + (weight * 10);

            if (zone == "REMOTE")
                cost += 30;

            return cost;
        }

        public decimal CalculateExpress(decimal weight, string zone)
        {
            decimal cost = 100 + (weight * 20);

            if (zone == "REMOTE")
                cost += 50;

            return cost;
        }

        public decimal CalculateInternational(decimal weight, string zone)
        {
            if (weight <= 2)
                return 500;

            if (weight <= 5)
                return 1000;

            decimal extra = weight - 5;
            return 1500 + (extra * 100);
        }

        public string Label(string serviceType)
        {
            switch (serviceType)
            {
                case "STANDARD": return "Standard Shipping (3-5 Days)";
                case "EXPRESS": return "Express Shipping (1-2 Days)";
                case "INTL": return "International Shipping (7–15 Days)";
                default: return "Unknown Service";
            }
        }
    }
}
