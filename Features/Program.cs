using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CSharp7 ob = new CSharp7();
            ////var res = ob.tupledemo();
            ////deconstruction
            //(var id, var name) = ob.tupledemo();
            ////Console.WriteLine("id " +res.Item1);
            ////Console.WriteLine("id " + res.Item2);
            //Console.WriteLine("id " + id);
            //Console.WriteLine("name " + name);
            ob.outDemo();
            ob.patternMatching();
            ob.Readability();
            ob.throwexpdemo();        
        }
    }
}
