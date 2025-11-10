using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_StaticClassDemo
{
    static class Multiplier
    {
        public static double pi = 3.14;
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b) { return a - b; }
        public static int Multiply(int a, int b) { return a * b; }
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("demoninator should not be zero");
            }
            return a / b;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Multiplier.Add(10, 5);
            Console.WriteLine("Addition: "+result);
            result = Multiplier.Subtract(14, 4);
            Console.WriteLine("Subtraction: " + result);
        }
    }
}
