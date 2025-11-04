using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Calculator
    {
        public void Calculate(int num1, int num2, out int addResult, out int difference, out int ProductResult,out int divisionResult)
        {
            addResult = num1 + num2;
            difference = num1 - num2;
            ProductResult = num1 * num2;
            divisionResult = num1 / num2;
        }
        //method with return and with args
        public int Addition(int a, int b)
        {
            int sum = a + b;
            int diff = a - b;
            return sum;
        }
        public void Subtraction(int a, int b)
        {
            Console.WriteLine($"Difference:{a-b}");
        }

    }
}
