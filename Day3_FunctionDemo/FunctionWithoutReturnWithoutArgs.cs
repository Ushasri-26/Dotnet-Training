using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_FunctionDemo
{
    internal class FunctionWithoutReturnWithoutArgs
    {
        public static void Main(string[] args)
        {
            Addition();
        }
        static void Addition()
        {
            int x, y, res;
            Console.WriteLine(" Enter the value for x and y");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            res = x + y;
            Console.WriteLine(" X+ y = " + res);
        }
    }
}
