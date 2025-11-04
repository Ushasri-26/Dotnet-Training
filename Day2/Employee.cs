using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Employee
    {
        private int empId;
        private string empName;
        private string designation;
        public void AcceptEmployeeDetails(int id, string name, string designation = "ASE")
        {
            this.empId = id;
            this.empName = name;
            this.designation = designation;
         
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Designation: " + designation);
        }
    }
}
