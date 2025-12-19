using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sportsdbEntities1 db = new sportsdbEntities1();
            Employee emp = new Employee();
            emp.Empid = "E101";
            emp.Empname = "Usha";
            emp.DepartmentName = "IT";
            emp.Salary = 20000;         
            emp.YearOfJoining = 2022;    
            db.Employees.Add(emp);
            db.SaveChanges();
            Console.WriteLine("Record Inserted");

            
            var empList = db.Employees.ToList();
            Console.WriteLine("Employee Records:");
            foreach (var e in empList)
            {
                Console.WriteLine(
                    e.Empid + " " +
                    e.Empname + " " +
                    e.DepartmentName + " " +
                    e.Salary
                );
            }

            
            var updateEmp = db.Employees.FirstOrDefault(x => x.Empid == "E101");
            if (updateEmp != null)
            {
                updateEmp.Salary = 25000;
                db.SaveChanges();
                Console.WriteLine("Record Updated");
            }

            
            var deleteEmp = db.Employees.FirstOrDefault(x => x.Empid == "E101");
            if (deleteEmp != null)
            {
                db.Employees.Remove(deleteEmp);
                db.SaveChanges();
                Console.WriteLine("Record Deleted");
            }

            Console.ReadLine();
        }
    }
}
