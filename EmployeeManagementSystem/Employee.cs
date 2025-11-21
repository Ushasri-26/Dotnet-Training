using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public int Experience { get; set; }

        public Employee(int empID, string name, string department, double salary, int experience)
        {
            EmpID = empID;
            Name = name;
            Department = department;
            Salary = salary;
            Experience = experience;
        }
        public override string ToString()
        {
            return $"ID: {EmpID}, Name: {Name}, Dept: {Department}, Salary: {Salary}, Exp: {Experience} yrs";          
        }
    }
}
