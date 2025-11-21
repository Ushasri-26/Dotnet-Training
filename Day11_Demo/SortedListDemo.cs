using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Demo
{
    internal class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList<int, string> products = new SortedList<int, string>();
            products.Add(101, "Laptop");
            products.Add(102, "Mobile");
            products.Add(103, "Tablet");
            products.Add(104, "MacBook");
            foreach (var item in products)
            {
                Console.WriteLine("key: " + item.Key + "value :" + item.Value);
            }
            SortedList<int, string> inventory = new SortedList<int, string>();
            inventory.Add(201, "Wheat-5Kg");
            inventory.Add(202, "Dal-5Kg");
            inventory.Add(203, "Ricebag-25Kg");
            inventory.Add(204, "Barley-1Kg");
            inventory.Add(205, "Sugar-2Kg");
            inventory.Add(206, "Salt-1Kg");
            Console.WriteLine("\n Inventory Details");
            Console.WriteLine("First item Code " + inventory.Keys[0]);
            Console.WriteLine("Last item Code" + inventory.Values[inventory.Count - 1]);
            foreach (var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + "Value: " + item.Value);
            }
            //Search By Key
            Console.WriteLine("Enter the key to search");
            int keyToSearch = Convert.ToInt32((string)Console.ReadLine());
            if (inventory.ContainsKey(keyToSearch))
            {
                Console.WriteLine("Item Found: " + inventory[keyToSearch]);
            }
            else
            {
                Console.WriteLine("Item Not Found");
            }
            //Search By Value
            Console.WriteLine("Enter the value to search");
            string valueToSearch = Console.ReadLine();
            if (inventory.ContainsValue(valueToSearch))
            {
                Console.Write("Item Found with key: " + inventory.IndexOfValue(valueToSearch));
            }
            else
            {
                Console.WriteLine("Item Not Found");

            }        
            //update value
            Console.WriteLine("Enter the key to update the value");
            int keyToUpdate = Convert.ToInt32(Console.ReadLine());
            string newValue = Console.ReadLine();
            inventory[keyToUpdate]=newValue;
            Console.WriteLine("Updated Value " + inventory[keyToUpdate]);

            //Remove by key
            Console.WriteLine("Removing item code 203");
            inventory.Remove(203);
            Console.WriteLine("After Removal of 203");
            foreach (var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + "Value: " + item.Value);
            }

            //Remove by index
            inventory.RemoveAt(0);
            Console.WriteLine("After Removal of inex 0");
            foreach (var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + "Value: " + item.Value);
            }

            //Get Index of Key
            Console.WriteLine("Index of key 202" + inventory.IndexOfKey(202));
            inventory.Clear();
            Console.ReadLine();
        }
    }
}
