using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Properties
{
    class Student
    {
        private int age;
        private string name;
        private double salary = 45000;
        private string password="Admin123";

        public int Age
        {
            get { return age; }//using getting we returning the value & Read only property
            set {
                if (value < 0 || value > 120)
                    throw new Exception("Age should be between 0 and 120"); 
                age = value;//write only property 
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Read Only Property
        public double Salary
        {
            get { return salary; }//Read only property
        }

        public string Password
        {
            set { password = value; }//write only property
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student student = new Student();
                //student.Age = 22;
                student.Name = "Usha sri";
                Console.WriteLine("Enter the age:");
                student.Age=Convert.ToInt32(Console.ReadLine());
                //student.salary=90000
                //student.password = "NewPass";

                Console.WriteLine("Student Information");
                Console.WriteLine("Name: "+student.Name);
                Console.WriteLine("Age: " + student.Age);
                Console.WriteLine("Salary: " + student.Salary);
                //Console.WriteLine("Password: " + student.password);
                Console.ReadLine();
            }
        }
    }
}

