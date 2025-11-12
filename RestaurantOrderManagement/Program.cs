using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderManagement
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
    public Order(int orderID, string customerName, decimal totalAmount)
        {
            OrderID = orderID;
            CustomerName = customerName;
            TotalAmount = totalAmount;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderID}, Customer: {CustomerName}, Total Amount: Rs.{TotalAmount}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList orderList= new ArrayList();
            orderList.Add(new Order(101, "Usha", 450.75m));
            orderList.Add(new Order(102, "Rahul", 320.50m));
            orderList.Add(new Order(103, "Priya", 890.00m));

            int choice;
            do
            {
                Console.WriteLine("\n====== Foodify Restaurant Order Management ======");
                Console.WriteLine("1. Add New Order");
                Console.WriteLine("2. Display All Orders");
                Console.WriteLine("3. Search Order by ID");
                Console.WriteLine("4. Remove Order by ID");
                Console.WriteLine("5. Show Total Number of Orders");
                Console.WriteLine("6. Sort Orders by Amount");
                Console.WriteLine("7. Reverse Orders (Latest First)");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddOrder(orderList);
                        break;
                    case 2:
                        DisplayOrders(orderList);
                        break;
                    case 3:
                        SearchOrder(orderList);
                        break;
                    case 4:
                        RemoveOrder(orderList);
                        break;
                    case 5:
                        Console.WriteLine($"Total number of orders: {orderList.Count}");
                        break;
                    case 6:
                        SortOrders(orderList);
                        break;
                    case 7:
                        orderList.Reverse();
                        Console.WriteLine("Orders reversed (latest first).");
                        break;
                    case 8:
                        Console.WriteLine("Exiting... Thank you for using Foodify System!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

            } while (choice != 8);
        }

        // Method to add a new order
        static void AddOrder(ArrayList orderList)
        {
            Console.Write("Enter Order ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Total Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            orderList.Add(new Order(id, name, amount));
            Console.WriteLine("✅ Order added successfully!");
        }

        // Method to display all orders
        static void DisplayOrders(ArrayList orderList)
        {
            if (orderList.Count == 0)
            {
                Console.WriteLine("No orders to display!");
                return;
            }

            Console.WriteLine("\n--- Current Orders ---");
            foreach (Order o in orderList)
            {
                Console.WriteLine(o);
            }
        }

        // Method to search an order by ID
        static void SearchOrder(ArrayList orderList)
        {
            Console.Write("Enter Order ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            foreach (Order o in orderList)
            {
                if (o.OrderID == id)
                {
                    Console.WriteLine("Order Found: " + o);
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Order not found!");
        }

        // Method to remove an order by ID
        static void RemoveOrder(ArrayList orderList)
        {
            Console.Write("Enter Order ID to remove: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Order toRemove = null;

            foreach (Order o in orderList)
            {
                if (o.OrderID == id)
                {
                    toRemove = o;
                    break;
                }
            }

            if (toRemove != null)
            {
                orderList.Remove(toRemove);
                Console.WriteLine("🗑️ Order removed successfully!");
            }
            else
            {
                Console.WriteLine("Order ID not found!");
            }
        }

        // Method to sort orders by amount
        static void SortOrders(ArrayList orderList)
        {
            orderList.Sort(new OrderAmountComparer());
            Console.WriteLine("Orders sorted by amount successfully!");
        }
    }

    // Custom comparer class to sort by TotalAmount
    class OrderAmountComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Order o1 = (Order)x;
            Order o2 = (Order)y;
            return o1.TotalAmount.CompareTo(o2.TotalAmount);
        }

    }
}

