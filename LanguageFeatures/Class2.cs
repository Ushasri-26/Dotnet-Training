using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LanguageFeatures
{
    // .Net 4.x Features
    internal class Class2
    {
        public delegate object mydel();//base type
        public delegate void mydel2(string st);//derived type
        public string cov() { return "hi"; }// derived type
        public void con(object st) // base type
        { WriteLine("Usha"); } 

        //Named and Optional parameters
        //optional parameter:is acheived by assigning the default value for parameter
        //named parameter:is acheived by using parameter name and the pass the value
        //drawback is:it may not run if use function overloading
        public void NamedoptionalDemo(int x = 10, int y = 40)
        {
            int result = x + y;
            WriteLine($"The sum is {result}");
        }
        public void NamedoptionalDemo()//it will run first because without parameters that runs first
        {
            WriteLine("Hello world!");
        }

        //Co and Conta variance
        public void CoVariance_Contravariance()
        {
            //this feature is used for delegates
            //feature:to make delegate 
            // .net 1.0
            //Co variance you can use a derived type instead of base type
            string[] st = { "hello", "Usha sri"};
            object[] o = st;
            IEnumerable<string>names = new List<string>();
            IEnumerable<object> objs = names; //Co-Variance valid
            mydel d = cov;
            WriteLine(d());

            mydel2 d2 = con;
            d2("hi");
        }
        public void dynamicDemo()
        {
            //var: variant
            //drawback: 1.var cannot be declared globally
            //          2.Multiple var values not allowed in a single line
            //          3. you have to assign the values
            //          4. null values cannot assigned
            //          5. Cannot be used as function parameter
            //var a = 100;// datatype is checked at compile time
            //var a1 = "hi";
            //var a2 = a * a1;
            //var b = "Usha";
            //var c = 2.5;

            //dynamic m = 100;// datatype is checked at runtime
            //dynamic n = 20;
            //dynamic o = m * n;
            //int x;
            //x = 10; //valid

            //var p; //not valid
            //p = 10

            //var x= null;

            dynamic a = 10; //integer
            WriteLine(a);

            a = "Usha"; //string
            WriteLine(a);

            a = 25.5; // double
            WriteLine(a);

        }
    }
}
