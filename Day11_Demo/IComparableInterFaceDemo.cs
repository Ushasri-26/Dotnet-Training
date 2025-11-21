using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Demo
{
    public class InfiniteEmployee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
    internal class IComparableInterFaceDemo
    {
        static void Main(string[] args)
        {
                List<InfiniteEmployee>infiniteEmployees = new List<InfiniteEmployee>();
                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 1806852, EmployeeName = "Usha sri", Salary = 100000, Age=22, Location = "Vizag" });

                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 1806851, EmployeeName = "Monika", Salary = 50000, Age = 21, Location = "Vizag" });
                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 2, EmployeeName = "Sakthivel", Salary = 9000, Age = 21, Location = "Hydrebad" });
                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 3, EmployeeName = "Madavi", Salary = 800000, Age = 23, Location = "Bangalore" });
                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 1807012, EmployeeName = "Deepti Sahu", Salary = 21000, Age = 23, Location = "Chennai" });
                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 1807018, EmployeeName = "Kanishka Chandran", Salary = 37500, Age = 20, Location = "Hyderabad" });
                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 1807023, EmployeeName = "Deepalakshmi", Salary = 60000, Age = 21, Location = "Hyderabad" });
                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 1807031, EmployeeName = "Aasritha", Salary = 80000, Age = 21, Location = "Chennai" });
                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 6, EmployeeName = "Sairam", Salary = 18000, Age = 23, Location = "Chennai" });
                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 1807001, EmployeeName = "Humera", Salary = 21000, Age = 24, Location = "Bangalore" });
                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 1807006, EmployeeName = "Manikanta sai", Salary = 50000, Age = 24, Location = "Chennai" });
                infiniteEmployees.Add(new InfiniteEmployee { EmployeeID = 1807029, EmployeeName = "Logeshwaran V", Salary = 50000, Location = "Bangalore" });


            }
        }
}
