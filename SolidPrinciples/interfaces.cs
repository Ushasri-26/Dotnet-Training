using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SolidPrinciples
{
    interface inter1
    {
        void Add(int x, int y);//different logic 11
    }
    interface inter2
    {
        void Add(int x, int y);//different logic the sum is 11
    }
    internal class interfaces : inter1, inter2
    {
        internal void Add(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        void inter1.Add(int x, int y)
        {
            WriteLine(x + y);
        }
        void inter2.Add(int x, int y)
        {
            WriteLine($"the sum is {x+y}");
            // the sum is 11
        }
    }
}