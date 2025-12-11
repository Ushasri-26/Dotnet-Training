using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET
{
    internal class Arrays
    {
        List<int> listA = new List<int> { 10, 20, 30, 40, 50, 20, 30 };
        List<int> listB = new List<int> { 30, 40, 50, 60, 70, 40 };

        List<string> names1 = new List<string> { "Akshay", "Aasritha", "Deepa", "Kiran", "Kiran" };
        List<string> names2 = new List<string> { "Kiran", "Manikanta", "Deepa", "Naveen" };

        int[] numbers = { 1, 4, 9, 16, 25, 36 };
        string[] st = { "India", "Srilanka", "canada", "Singapore" };
        //Q1. Write a LINQ query to fetch unique values from listA.
        //Expected Output: 10, 20, 30, 40, 5
        public void UniqueVal()
        {
            var result = listA.Distinct();
            Console.WriteLine("Unique values from listA:");
            foreach (var a in result)
            { 
                Console.WriteLine(a);
            }
        }
        //Q2. Combine values from listA and listB without duplicates
        public void WithoutDup()
        {
            var result = listA.Union(listB);
            Console.WriteLine("Combine listA & listB without duplicates:");
            foreach (var a in result) 
                Console.WriteLine(a);
        }
        //Q3. Find items common in listA and listB.
        public void CommonItems()
        {
            var result = listA.Intersect(listB);
            Console.WriteLine("Common items in listA & listB:");
            foreach (var a in result) 
                Console.WriteLine(a);
        }
        //Q4. Find names present in names1 but not in names2
        public void NameinANotinB()
        {
            var result = names1.Except(names2);
            Console.WriteLine("Names in names1 but not in names2:");
            foreach (var a in result)
                Console.WriteLine(a);
        }
        //Q7. Find the highest value in listA
        public void HighestVal()
        {
            var result = listA.Max();
            Console.WriteLine("Highest value in listA: " + result);
        }
        //Q8. Write a LINQ query to find numbers divisible by 3
        //int[] numbers = { 1, 4, 9, 16, 25, 36 };
        public void divby3()
        {
            var result = numbers.Where(n => n % 3 == 0);
            Console.WriteLine("Numbers divisible by 3:");
            foreach (var a in result)
                Console.WriteLine(a);
        }
        //Q9. Write a Linq to query to sort based on string Length
        //string[] st = { "India", "Srilanka", "canada", "Singapore" }
        public void StrLength()
        {
            var result = st.OrderBy(s => s.Length);
            Console.WriteLine("Strings sorted by length:");
            foreach (var a in result) 
                Console.WriteLine(a);
        }

    }
}
