using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SolidPrinciples
{
    public interface IDiscount
    {
        decimal GetDiscount();
    }
    public class VIPDiscount : IDiscount
    {
        public decimal GetDiscount()
        {
            return 0.8m;
        }
    }
    public class EmployeeDiscount : IDiscount
    {
        public decimal GetDiscount()
        {
            return 0.5m;
        }
    }
    public class NoDiscount : IDiscount
    {
        public decimal GetDiscount()
        {
            return 0m;
        }
    }
    public class DiscountService
    {
        public decimal ApplyDiscount(IDiscount discount)
        {
            return discount.GetDiscount();
        }
    }
    internal class OCP
    {
        public static void Main(string[] args)
        {
            DiscountService discountService = new DiscountService();

            IDiscount vip = new VIPDiscount();
            IDiscount employee = new EmployeeDiscount();
            IDiscount regular = new NoDiscount();

            WriteLine("VIP Discount: " + discountService.ApplyDiscount(vip));
            WriteLine("Employee Discount: " + discountService.ApplyDiscount(employee));
            WriteLine("Regular Discount: " + discountService.ApplyDiscount(regular));

            ReadLine(); 
        }
    }
}
