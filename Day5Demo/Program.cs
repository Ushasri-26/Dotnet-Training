using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Demo
{
//by default the acesss specifier is private.we cant acess private members by using obejct.
        class person
        {
        string name;
        int age;
        string location;
        public person(string name,int age,string location)
        {
            this.name = name;
            this.age = age;
            this.location = location;
            Console.WriteLine("Person or Base class constructor");
        }
        
        public void getPersonDetails()
        {
            Console.Write("enter name:");
            name = Console.ReadLine();
            Console.Write("enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter location:");
            location = Console.ReadLine();
        }

        protected void displayPerson()
        {
            Console.WriteLine($"name :{name}, age: {age}, locatoion:{location}");
        }

        }
        class Employee : person
        {
            int employeeId;
            //string empName
            double employeeSalary;
            string designation;
        public Employee(string name,int age,string location,int id,string designation,double sal):base(name,age,location)
        {
            this.employeeId = id;
            this.employeeSalary = sal;
            this.designation = designation;
            Console.WriteLine("child class constructor");
        }
        public void getEmployeeDetails()
            {
                getPersonDetails();
                Console.Write("employee Id:");
                employeeId = Convert.ToInt32(Console.ReadLine());
            //Console.Write("employee empname");
            //empName =Console.ReadLine();
                Console.Write("employee salary:");
                employeeSalary = Convert.ToDouble(Console.ReadLine());
                Console.Write("employee designation:");
                designation = Console.ReadLine();
            }//here display is a private method so we cant acess it putside the class.so we are calling it inside getDetaisl class..
            public void display()
            {
                displayPerson();
                Console.WriteLine($"Id : {employeeId}, salary :{employeeSalary}, designation :{designation}");
            }
        }

        //inheritance we are using here :

        internal class Program 
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee("Usha sri", 22, "vizag", 201, "Trainee", 18900);
                //emp.getEmployeeDetails();
                //emp.getPersonDetails();//instead of calling here the derived class methods can call the methods 
                emp.display();
                //emp.displayPerson();//child class object cannot access parent class protected members only
                Console.ReadLine();
                
            }
        }
    }



       