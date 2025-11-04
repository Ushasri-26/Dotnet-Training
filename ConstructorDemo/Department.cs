using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Department
    {
        int departmentId;
        string departmentName, deptLocation;
       //default constructor or parameterless constructor
        static Department()
        {
            Console.WriteLine("Static constructor\n");
        }
        public Department()
        {
            departmentId = 1;
            departmentName = "Health Care";
            deptLocation = "Hyderabad";
            Console.WriteLine("Default or Parameterless Constructor called");
        }
        public Department(int id,string name,string location)
        {
            Console.WriteLine("Parameterised constructor called");
            this.departmentId = id;
            this.departmentName = name;
            this.deptLocation = location;
        }
        public Department(Department dept)
        {
            Console.WriteLine("Copy constructor called");
            this.departmentId= 104;
            this.departmentName= "HR";
            this.deptLocation= "Banglore";
        }

        public void getDepartmentInfo()
        {
            Console.WriteLine("Enter Department Id:");
            departmentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of Department:");
            departmentName = Console.ReadLine();
            Console.WriteLine("Enter Location of Department:");
            deptLocation = Console.ReadLine();
        }
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine("Department Details");
            Console.WriteLine("Id:" + departmentId);
            Console.WriteLine("Name:"+departmentName);
            Console.WriteLine("Location:" + deptLocation);
        }
    }
}
