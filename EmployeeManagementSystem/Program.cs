using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeesList = new List<Employee>()
            {
                new Employee(1, "Anurag" , "Finance", 80000, 5),
                new Employee(2, "Uday Kiran", "IT", 120000, 4),
                new Employee(3, "Srinivas", "Marketing", 320000, 15),
                new Employee(4, "Monika", "Sales", 30000, 1),
                new Employee(5, "Pranav", "HR", 55000, 2),
                new Employee(6, "Durga", "IT", 40000, 3),
                new Employee(7, "Gowthami", "Marketing", 60000, 2),
                new Employee(8, "Satwik", "Sales", 70000, 6),
                new Employee(9, "Usha sri", "IT", 50000, 2),
                new Employee(10, "Anvith", "IT", 45000, 2),
            };

            Console.WriteLine("\n===== ALL EMPLOYEES =====");
            employeesList.ForEach(e => Console.WriteLine(e));

            var highSalary = employeesList.FindAll(e => e.Salary > 50000);
            var itEmployees = employeesList.FindAll(e => e.Department == "IT");
            var experienced = employeesList.FindAll(e => e.Experience > 5);
            var namesWithA = employeesList.FindAll(e => e.Name.StartsWith("A"));

            Console.WriteLine("\n===== Salary > 50,000 =====");
            highSalary.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("\n===== IT Department =====");
            itEmployees.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("\n===== Experience > 5 Years =====");
            experienced.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("\n===== Names Starting With A =====");
            namesWithA.ForEach(e => Console.WriteLine(e));

            
            Console.WriteLine("\n===== Sorted By Name (A-Z) =====");
            employeesList.Sort((e1, e2) => e1.Name.CompareTo(e2.Name));
            employeesList.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("\n===== Sorted By Salary (High to Low) =====");
            employeesList.Sort((e1, e2) => e2.Salary.CompareTo(e1.Salary));
            employeesList.ForEach(e => Console.WriteLine(e));

            Console.WriteLine("\n===== Sorted By Experience (Low to High) =====");
            employeesList.Sort((e1, e2) => e1.Experience.CompareTo(e2.Experience));
            employeesList.ForEach(e => Console.WriteLine(e));
            
            var promotionList = employeesList.FindAll(e => e.Experience >= 5 && e.Salary < 80000);

            Console.WriteLine("\n===== PROMOTION LIST =====");
            promotionList.ForEach(e => Console.WriteLine(e));

            Console.ReadLine();
        }
    }
}
