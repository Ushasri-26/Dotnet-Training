using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
namespace LanguageFeatures
{
    // .Net version 6.0 Language features
    internal class Feature6
    {
        public void staticdemo()
        {
            // feature : how to avoid console class every time
            // how do you print hello world?
            WriteLine("Hello world");
            WriteLine("Hi students how r u all");

            //how do you find sqrt
            var res = Sqrt(100);
            WriteLine(res);

        }
        public void autoinitdemo()
        {
            //feature : how to initialize property without constructor
            Employee e = new Employee();
            WriteLine(e.EmpId);
            WriteLine(e.EmpName);
        }
        public void dictionaryinitdemo()
        {
            //Feature: how to add values to dictionary without add method
            //Dictionary value
            Dictionary<int, string> dc = new Dictionary<int, string>()
            {
                [100] = "Andhrapradesh",
                [200] = "Vizag",
                [300] = "Ongole",
            };
            //dc.Add(100, "India");
            //dc.Add(200, "Vizag");
            //dc.Add(300, "Ongole");
            foreach (var item in dc)
            {
                WriteLine($"{item.Key} {item.Value}");
            }

        }
        public void Hi()
        {

        }
        public void nameofdemo()
        {
            //Feature : how do you print function name as it is?
            // we wanted function name for logging features
            WriteLine(nameof(Hi));
        }
        public void ExceptionFilters()

        {

            // Features : working with multiple catch blocks

            //in previous version u can declare exception only once

            //based on the message call the corresponding catch block

            //we oftenly use this feature when working with exceptins

            try

            {

                throw new Exception("hello");

            }

            catch (Exception ex) when (ex.Message == "Minor")

            {

                Console.WriteLine("Handled minor exception.");

            }

            catch (Exception ex) when (ex.Message == "Major")

            {

                Console.WriteLine("Major error occured.");

            }

            catch (Exception ex)

            {

                Console.WriteLine("General exception.");

            }
        }


        public void conditionalnull()
        {
            // Feature: how o u avoid null error or uninitialized object
            //without using if conditions we are using the ?. operator 
            Employee e = null; // u have not initialized    
                WriteLine(e?.EmpId); // print the value only if it is initialized
                WriteLine(e?.EmpName);
        }
        public void Expressionbody() => WriteLine("Hello Usha sri..How are you doing");

        class Employee
        {
            // we use constructors to assign default values
            //public Employee()
            //{
            //    EmpId = 101;
            //    EmpName = "Usha sri";
            //}
            // auto initializer property(constructoir not required)
            public int EmpId { get; set; } = 100;
            public string EmpName { get; set; } = "Usha sri";

        }

    }
}
