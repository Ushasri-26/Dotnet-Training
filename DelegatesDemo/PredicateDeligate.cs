using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace DelegateDemo

{

    public class Employee

    {

        public int EmpId { get; set; }

        public string Name { get; set; }

        public int Experience { get; set; }

    }

    internal class PredicateDelegateDemo

    {

        static void Main(string[] args)

        {

            List<Employee> employees = new List<Employee>()

            {

                new Employee    { EmpId=101, Name="Alice", Experience=5},

                new Employee    { EmpId=102, Name="Bob", Experience=3},

                new Employee    { EmpId=103, Name="Charlie", Experience=7},

                new Employee    { EmpId=104, Name="David", Experience=2},

                    new Employee    { EmpId=105, Name="Eve", Experience=4}

            };


            Predicate<Employee> IsEligble = emp => emp.Experience >= 3;

            var eleigibleEmployees = employees.FindAll(IsEligble);

            foreach (var emp in eleigibleEmployees)

            {

                Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.Name}, Experience: {emp.Experience} years");

            }

            Console.ReadLine();

        }

    }

}

