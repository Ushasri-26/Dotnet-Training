using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityBillingSystem
{
    internal class UtilityBill
    {
        public int CustomerID;
        public string CustomerName;
     
        //static values
        public static double ServiceCharge = 50.0;
        public static double TaxRate = 0.10;
        public static double RatePerUnit = 6.393333;

        //params method
        public double GetTotalUsage(params double[] usage)
        {
            double sum = 0;
            foreach (double u in usage)
            {
                sum += u;
            }
            return sum;
        }
        public void CalculateBill(double usage,out double totalAmount, out double tax, out double netpay)
        {
            double baseBill = usage * RatePerUnit;
            totalAmount = baseBill + ServiceCharge;
            tax = totalAmount * TaxRate;
            netpay = totalAmount + tax;
        }
    }
}
