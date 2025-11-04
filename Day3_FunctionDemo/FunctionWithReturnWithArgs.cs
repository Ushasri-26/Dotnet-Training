using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_FunctionDemo
{
    internal class FunctionWithReturnWithArgs
    {
        public static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine(" Enter the value for a and b");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            int result = Addition(x, y);
            Console.WriteLine(" given vales sum are " + result);
            Console.ReadLine();
        }
        static int Addition(int x, int y)
        {
            int res;
            res = x + y;
            return res;
        }
    }
}
