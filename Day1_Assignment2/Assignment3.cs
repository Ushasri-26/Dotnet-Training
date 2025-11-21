using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assignment2
{
    internal class Assignment3
    {
        public static void Run()
        {
            Console.WriteLine("======Assignment 3======");

            int number = 5;

            Task<int> factorialTask = Task.Run(() => Factorial(number));

            Console.WriteLine($"Factorial of {number} = {factorialTask.Result}");
        }

        private static int Factorial(int n)
        {
            int fact = 1;

            for (int i = 1; i <= n; i++)
                fact *= i;

            return fact;
        }
    }
}