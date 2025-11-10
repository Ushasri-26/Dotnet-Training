using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class InterestCalculator
    {
        public void CalculateInterest(double principal, double rate)
        {
            double interest = (principal * rate * 1) / 100;
            Console.WriteLine("Simple Interest (1 year): " + interest);
        }
        public void CalculateInterest(double principal, double rate, int time)
        {
            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Simple Interest (" + time + " years): " + interest);
        }
        public void CalculateInterest(double principal, double rate, int n, int time)
        {
            double amount = principal * Math.Pow((1 + (rate / (100 * n))), n * time);
            double ci = amount - principal;
            Console.WriteLine("Compound Interest: " + ci);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            InterestCalculator ic = new InterestCalculator();

            // Call all overloaded methods
            ic.CalculateInterest(10000, 5);               // Method 1
            ic.CalculateInterest(10000, 5, 3);            // Method 2
            ic.CalculateInterest(10000, 5, 4, 2);         // Method 3

            Console.ReadLine();
        }
    }
}

