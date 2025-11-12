using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    internal class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "Usha");
            ht.Add(2, "Uday");
            ht.Add("eid", 109);
            ht.Add("dept", "IT");
            ht.Add("location", "Vizag");
            ht["email"] = "abc@gmail.com";
            ht[56] = "Test Value";
            Console.Write("Hash table values are");
            Console.WriteLine("First Value:" + ht[1]);
            Console.WriteLine("Coutn of Hash Table: " + ht.Count);
            Console.WriteLine("The key 56 is available or not : " + ht.ContainsKey(56));
            Console.WriteLine("The value abc@gmail.com is Available or not: "+ht.ContainsValue(56));
            ht.Remove(2);
            Console.WriteLine("\n Hash table keys are");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("Key: " +item);
            }
            Console.WriteLine("\n Hash table values are");
            foreach (var item in ht.Values)
            {
                Console.WriteLine("Values: " + item);
            }
            Console.WriteLine("\n Hash table Keys and Values are");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+" - " +item.Value);
            }
            object[] keysArray = new object[ht.Keys.Count];//key should be unique and it value may be any type like int,string or wahtever
            ht.Keys.CopyTo(keysArray,0);
            Console.WriteLine("\n After copying all keys into keyArray");
            foreach (var key in keysArray)
            {
                Console.WriteLine(key);
            }
            Hashtable ht2 = new Hashtable();
            foreach (DictionaryEntry item in ht)
            {
                ht2[item.Key] = item.Value;
            }
            ht.Clear();
            Console.WriteLine("After clearing the hashtable " + ht.Count);
            Console.ReadLine();
        }
    }
}
