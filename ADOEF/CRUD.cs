using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOEF
{
    internal class CRUD
    {
        infinitedbEntities dc = new infinitedbEntities();
        public void showallemployees()
        {
            // it should display all emp from database

            var res = from t in dc.Employees
                      select t;

            foreach (var e in res)
            {
                Console.WriteLine($"{e.EmpID}  {e.EmpName}  {e.DateOfJoin}  {e.Salary}  {e.DeptID}");
                Console.WriteLine("========================");
            }

        }

        public void SearchRecord()
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();

            var res = from t in dc.Employees
                      where t.EmpName.Contains(name)
                      select t;

            foreach (var e in res)
            {
                Console.WriteLine($"{e.EmpID}  {e.EmpName}  {e.DateOfJoin}  {e.Salary}  {e.DeptID}");
                Console.WriteLine("========================");
            }
        }
        public void AddRecord()
        {
            //create obj of thetable which u want to add(employee)
            //initialize all the properties (step-1)
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the salary");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter the doj");
            DateTime doj = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("enter the deptid");
            int id = Convert.ToInt32(Console.ReadLine());
            Employee ob = new Employee() { EmpName = name, Salary = salary, DateOfJoin = doj, DeptID = id };
            //attach the object to property(step-2)
            dc.Employees.Add(ob);
            //update the changes to the database
            int i = dc.SaveChanges();//update all changes to db
            Console.WriteLine("total rows inserted is " + i);
        }

        public void DeleteRecord()
        {
            Console.WriteLine("Enter Employee ID to delete:");
            int id = Convert.ToInt32(Console.ReadLine());

            var emp = dc.Employees.FirstOrDefault(e => e.EmpID == id);

            if (emp == null)
            {
                Console.WriteLine("Employee not found!");
                return;
            }

            dc.Employees.Remove(emp);
            int rows = dc.SaveChanges();
            Console.WriteLine($"Employee deleted! Rows removed = {rows}");
        }

        public void UpdateRecord()
        {
            Console.WriteLine("enter the employeeid");
            int id = int.Parse(Console.ReadLine());


            var res = (from t in dc.Employees
                       where t.EmpID == id
                       select t).First();

            res.Salary = 55500;
            int i = dc.SaveChanges();// updates all change to database
            Console.WriteLine("total rows  updated is " + i);
        }
        public void DisplayRecord()
        {
            var res = from e in dc.Employees
                      join d in dc.Departments
                      on e.DeptID equals d.DeptID
                      select new { e.EmpID, e.EmpName, e.Salary, e.DeptID, d.DeptName };
            foreach (var item in res)
            {
                Console.WriteLine($"{item.EmpID}  {item.EmpName}  {item.Salary}  {item.DeptID}  {item.DeptName}");
            }
        }
        public void DisplayBothTable()
        {
            var res = from e in dc.Employees
                      join d in dc.Departments
                      on e.DeptID equals d.DeptID
                      select new
                      {e.EmpID,e.EmpName,e.DeptID,e.Salary};
            foreach (var item in res)
            {
                Console.WriteLine($"{item.EmpID}  {item.EmpName}  {item.DeptID}  {item.Salary}");
            }
        }
        public void DatesFromUser()
        {
            Console.WriteLine("Enter start date (dd-MM-yyyy):");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter end date (dd-MM-yyyy):");
            DateTime end = DateTime.Parse(Console.ReadLine());
            var res = from e in dc.Employees
                      where e.DateOfJoin >= start && e.DateOfJoin <= end
                      select e;
            foreach (var item in res)
            {
                Console.WriteLine($"{item.EmpID}  {item.EmpName}  {item.DateOfJoin}  {item.Salary}");
            }
        }
        public void SalWithBonus()
        {
            var res = from e in dc.Employees
                      select new { e.EmpID, e.EmpName, e.Salary, BonusSalary = e.Salary + (e.Salary * 0.30m) };
            foreach (var e in res)
            {
                Console.WriteLine($"{e.EmpID}  {e.EmpName}  {e.Salary}  {e.BonusSalary}");
            }

        }
    }

}

