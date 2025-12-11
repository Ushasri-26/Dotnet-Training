using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ADONET
{
    class Products
    {
        public int pid { get; set; }
        public string pname { get; set; }
        public int price { get; set; }
        public int qty { get; set; }
    }
    internal class ProductsDemo
    {
        List<Products> li = new List<Products>()
        {
            new Products() { pid = 100, pname = "book", price = 1000, qty = 5 },
            new Products() { pid = 200, pname = "cd", price = 2000, qty = 6 },
            new Products() { pid = 300, pname = "toys", price = 3000, qty = 5 },
            new Products() { pid = 400, pname = "mobile", price = 8000, qty = 6 },
            new Products() { pid = 600, pname = "pen", price = 200, qty = 7 },
            new Products() { pid = 700, pname = "tv", price = 30000, qty = 7 },
        };
        //1. find second highest price
        public void SecHighest()
        {
            var secondHighest = li.OrderByDescending(p=>p.price).Skip(1).FirstOrDefault();
            Console.WriteLine("==================================================");
            Console.WriteLine("Second Highest Price = " + secondHighest.price);
        }
        //2. display top 3 highest price
        public void Top3High()
        {
            var top3 = li.OrderByDescending(p => p.price).Take(3);
            foreach (var p in top3)
            {
                Console.WriteLine(p.pname + " - " + p.price);
            }
        }
        //3. find the sum of price where product names contains letter 'O' 
        public void SumOfPrice()
        {
            var sum = li.Where(p => p.pname.ToLower().Contains("o")).Sum(p => p.price);
            Console.WriteLine("==================================================");
            Console.WriteLine("Sum Of Price = " + sum);
        }
        //4. find the product name ends with e and display only pid and pname(filter by
        //column name)
        public void ProdEndI()
        {
            var result = li.Where(p => p.pname.EndsWith("e"))
               .Select(p => new { p.pid, p.pname });

            foreach (var item in result)
            {
                Console.WriteLine("==================================================");
                Console.WriteLine(item.pid + "  " + item.pname);
            }
        }
        //5. group all records by qty find max of price
        public void GrpByQty()
        {
            var groups = li.GroupBy(p => p.qty)
               .Select(g => new
               {
                   Qty = g.Key,MaxPrice = g.Max(x => x.price)
               });
            foreach (var g in groups)
            {
                Console.WriteLine("Qty = " + g.Qty + " Max Price = " + g.MaxPrice);
            }
        }
        // Find sum of price of all products.
        public void SumOfProdPrice()
        {
            var sum = li.Sum(p => p.price);
            Console.WriteLine("=============================");
            Console.WriteLine("Total Price = " + sum);
        }
        // Find count of products where price > 5000.
        public void PriceGreaterThan5000()
        {
            var count = li.Count(p => p.price > 5000);
            Console.WriteLine("================================");
            Console.WriteLine("Count= " + count);
        }
    }
}
