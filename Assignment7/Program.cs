using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color, action;
            Console.Write("Enter light color:");
            color= Console.ReadLine();
            if (color == "Red")
                action = "Stop";
            else if (color == "Yellow")
                action = "Get Ready";
            else if (color == "Green")
                action = "Go";
            else
                action = "Invalid color! Please enter Red,Yellow, or Green";
            Console.Write($"Action:{action}");
            Console.ReadLine();

        }
    }
}
