using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD c = new CRUD();
            c.showallemployees();
            // c.SearchRecord();
            // c.AddRecord();
            // c.DeleteRecord();
            //c.UpdateRecord();
            //c.DisplayRecord();
            //c.DisplayBothTable();
            //c.DatesFromUser();
            //c.SalWithBonus();
            //c.SqlqueryDemo();
            //c.DMLDemo();
            c.spdemo();
        }
    }
}
