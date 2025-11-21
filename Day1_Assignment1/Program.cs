using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day1_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1:Partial class
            Student1 s = new Student1 { Name = "Usha sri", Age = 22 };
            s.DisplayDetails();

            WriteLine("--------------------------------------------------");

            //Assignment 2 : String Extension (IsUpper)
            string name = "hello";
            string test = "USHA";
            WriteLine($"{name.IsUpper()}");
            WriteLine($"{test.IsUpper()}");

            WriteLine("--------------------------------------------------");

            //Assignment 3 : SumOfSquares
            List<int> nums = new List<int> { 2,3,4};
            WriteLine("Sum Of Squares: " + nums.SumOfSquares());

            ReadLine();
        }
    }
}
