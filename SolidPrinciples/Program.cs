using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SolidPrinciples
{
    public class Invoice
    {
        public void GenerateInvoice()
        {
            WriteLine("Invoice Generated");
        }
    }
    public class Database
    {
        public void SaveToDatabase(Invoice invoice)
        {
            WriteLine("Saved to database");
        }
    }
    public class Email
    {
        public void SendEmail(Invoice invoice)
        {
            WriteLine("Sent via Email");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.GenerateInvoice();

            Database database = new Database(); 
            database.SaveToDatabase(invoice);

            Email email = new Email();
            email.SendEmail(invoice);

            DiscountService discountService = new DiscountService();

            IDiscount vip = new VIPDiscount();
            IDiscount employee = new EmployeeDiscount();
            IDiscount regular = new NoDiscount();

            WriteLine("VIP Discount: " + discountService.ApplyDiscount(vip));
            WriteLine("Employee Discount: " + discountService.ApplyDiscount(employee));
            WriteLine("Regular Discount: " + discountService.ApplyDiscount(regular));

            //interfaces

            interfaces ob = new interfaces();
            ob.Add(10, 20);
            // injector code

            //Mathcls ob = new Mathcls(new service());// constructor injection

            Mathcls ab = new Mathcls();
            //ob.GetInstance = new service();// property injection
            ab.show(new service());// method injection
        }
    }
}
