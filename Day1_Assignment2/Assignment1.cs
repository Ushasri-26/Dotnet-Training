using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day1_Assignment2
{
    internal class Assignment1
    {
        public static void Run()
        {
            WriteLine("======Assignment1======");
            Task t1 = Task.Run(() =>
            {
                for (int i = 1; i <= 5; i++)
                    WriteLine($"Task 1: {i}");
            });

            Task t2 = Task.Run(() =>
            {
                for (int i = 6; i <= 10; i++)
                    WriteLine($"Task 2: {i}");
            });

            Task t3 = Task.Run(() =>
            {
                WriteLine("Task 3: All numbers printed!");
            });

            Task.WaitAll(t1, t2, t3);

            WriteLine("Done");
        }
    }
}
