using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assignment1
{
    public static class EnumerableExtension
    {
        public static int SumOfSquares(this IEnumerable<int> numbers)
        {
            int sum = 0;

            foreach (int i in numbers)
            {
                sum += i * i;
            }
            return sum;
        }
    }
}
