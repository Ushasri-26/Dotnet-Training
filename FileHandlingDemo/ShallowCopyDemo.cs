using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public Address DeepCopy()
        {
            return new Address
            {
                City = this.City,
                Street = this.Street
            };
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address HomeAddress { get; set; } // refernce
        //public Employee ShallowCopy()
        //{
        //    return (Employee)this.MemberwiseClone();
        //}
        public Employee DeepCopy()
        {
            Employee ClonedEmployee = (Employee)this.MemberwiseClone(); // Shallow first
            ClonedEmployee.HomeAddress = this.HomeAddress.DeepCopy(); //Fix reference
            return ClonedEmployee;
        }
    }
    internal class ShallowCopyDemo
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee {  Name= "Usha" , Age= 22, HomeAddress = new Address { City = "Vizag", Street = "1at Avenue" } };
            //Employee emp2 = emp1.ShallowCopy();
            Employee emp2 = emp1.DeepCopy();

            emp2.Name = "Uday";
            emp2.HomeAddress.City = "Ongole";

            Console.WriteLine("emp1.name : " + emp1.Name);
            Console.WriteLine($"emp1.HomeAddress : " + emp1.HomeAddress.City);

            Console.WriteLine("emp2.name : " + emp2.Name);
            Console.WriteLine($"emp2.HomeAddress : " + emp2.HomeAddress.City);
            Console.ReadLine();
        }
    }
}
