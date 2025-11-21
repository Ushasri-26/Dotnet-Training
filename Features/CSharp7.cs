using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    internal class CSharp7
    {
        public (int, string) tupledemo()
        {
            //Features : using tuple u can return multiple values
            //now its standards
            //tuple means working with multiple values
            int id = 100;
            string name = "Usha";
            return (id, name);

        }
        //Minimizing Out variables
        public void outDemo()
        {
            //converting from string to integer?
            //int.Parse//Converts string int
            //double.Parse //Converts string double
            //float.Parse //Converts string float
            //int a = int.Parse(Console.ReadLine());
            //Features : the better way/safest way to typecast
            //try parse will avoid runtime errors
            int x;
        var res = int.TryParse(Console.ReadLine(), out x);
            if (res == true)
                Console.WriteLine("u have entered " + x);
            else
                Console.WriteLine("Convertion Failed");
        }
        //Pattern Matchings
        public void patternMatching()
        {
            //Feature : avoid typecasting
            // will also make code look compact
            // This feature is widely used in switch cases and if conditions
            //we cannot use ">" symnbol for objects

            //object shape = "Circle";
            //Console.WriteLine(shape.GetType().Name);
            //switch(shape.GetType().Name)
            //{
            //    case "Int32":
            //        int n = (int)shape; //explicit cast
            //        if (n > 0)
            //            Console.WriteLine("Positive Number");
            //        else
            //            Console.WriteLine("Unknown");
            //        break;
            //    case "String":
            //        string s = (string)shape; //explicit cast
            //        if (s == "Circle")
            //            Console.WriteLine("It's a circle");
            //        else
            //            Console.WriteLine("Unknown");
            //        break;

            //    default:
            //        Console.WriteLine("Unknown");
            //        break;

            //object shape = "Circle";
            //switch (shape)
            //{
            //    case int n when n > 0:
            //        Console.WriteLine("Positive Number");
            //        break;
            //    case string s when s == "Circle":
            //        Console.WriteLine("It's a Circle");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown");
            //        break;
            //}

            //int marks = 82;
            //string result = marks switch
            //{
            //    >= 90 => "Excellent",
            //    >= 75 => "Good",
            //    >= 50 => "Average",
            //    _ => "Fail" //Default
            //};
            //Console.WriteLine(result);
        }
        public void Readability()
        {
            // Feature : using _ instead of ,
            int x = 10_00_00_000; //valid(instead of comma here we replace with underscore keyword)
            Console.WriteLine(x);
        }

        public string LocalFunction(int a)
        {
            //Features : how to next the function(function inside the function)
            // use this feature if the function grows too long
            //use this feature of u have resuable code within the function
            string greatest(int x) // the value is taken from parent function
            {
                if (x > 10)
                    return "x is greater than 10";
                else
                    return "x is not greater than 10";
            }
            return greatest(a);
        }

        //Throws Expressions
        public void throwexpdemo()
        {
            string st = "Usha";
            //older way
            if (st == null)
                throw new ArgumentException("exp occured");
            //new way(assigning the value of st to res, only its not null)
            string res =
                st ?? throw new ArgumentException("exp occured");
        }
    }
}


