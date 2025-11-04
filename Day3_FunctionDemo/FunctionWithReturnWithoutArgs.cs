using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_FunctionDemo
{
    internal class FunctionWithReturnWithoutArgs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function with Return Without args");
            Console.WriteLine("Addition Result:"+Addition());
            int result = Addition();
            Console.WriteLine($"Addition Result:" +result);
            //Console.WriteLine(Addition());
        }
        static int Addition()
        {
            int num1, num2, sum;
            Console.WriteLine("enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            return sum;
        }
    }
}
