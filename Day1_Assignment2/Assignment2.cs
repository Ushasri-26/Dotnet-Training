using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day1_Assignment2
{
    internal class Assignment2
    {
        public static void Run()
        {
            WriteLine("=======Assignment2======");
            Random rnd = new Random();
            Task<int> T1 = Task.Run(() => rnd.Next(1, 100));
            Task<int> T2 = Task.Run(() => rnd.Next(1, 100));
            Task<int> T3 = Task.Run(() => rnd.Next(1, 100));

            Task.WhenAll(T1, T2, T3).ContinueWith(T =>
            {
                int sum = T1.Result + T2.Result + T3.Result;
                Console.WriteLine($"Randoms: {T1.Result}, {T2.Result}, {T3.Result}");
                Console.WriteLine($"Sum: {sum} \n ");
            }).Wait(); 
        }

    }
}
