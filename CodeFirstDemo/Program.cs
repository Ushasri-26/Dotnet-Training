using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // biggest advantage
            //u can still write a linq query even if table or database doesnot exists
            //we don't have any database by name sportsdb + ipl
            CRUDDEMO c=new CRUDDEMO();
            c.Insert();
        }
    }
}
