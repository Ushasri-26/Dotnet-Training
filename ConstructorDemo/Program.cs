using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Department dept = new Department();
            //dept.getDepartmentInfo();
            dept.DisplayDepartmentInfo();

            Department dept1=new Department(2,"HR","Banglore");
            dept1.DisplayDepartmentInfo();

            Department dept2 = new Department(3, "TL", "Hyderabad");
            dept2.DisplayDepartmentInfo();

            Department dept3 = new Department(dept2);
            dept3.DisplayDepartmentInfo();
            Console.ReadLine();
        }
    }
}
