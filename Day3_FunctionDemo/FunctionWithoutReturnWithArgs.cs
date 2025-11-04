using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_FunctionDemo
{
    internal class FunctionWithoutReturnWithArgs
    {
        public static void Main(string[] args)
        {
            Addition(10, 20);
            int c, d;
            Console.WriteLine("Enter the value from c and d");
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            Addition(c, d);
            Console.ReadLine();
        }
            static void Addition(int a, int b)
            {
                int res;
                res = a + b;
                Console.WriteLine("a+b=" + res);
            }
        }
    }

          
