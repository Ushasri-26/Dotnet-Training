using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadedLogMethods
{
    class Onlinestore
    {
        public void Checkout(int price)
        {
            Console.WriteLine("the price of product is " + price);
        }
        public void Checkout(int price, int quantity)
        {
            Console.WriteLine($"the price of product is {price} and quantity is {quantity}");
            int amount = price * quantity;
            Console.WriteLine("the amount is " + amount);
        }
        public void Checkout(int price, int quantity, string couponCode)
        {
            Console.WriteLine($"the couponcode of product is {couponCode} price of product is {price} and quantity is {quantity}");
        }
    }

    internal class OnlineStore
    {
        static void Main(string[] args)
        {
            Onlinestore onlinestore = new Onlinestore();
            onlinestore.Checkout(1000);
            onlinestore.Checkout(1000, 2);
            onlinestore.Checkout(1000, 3, "MNXRW2603");
            Console.ReadLine();
        }
    }
}
