using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class PersonalDetails
    {
        public string Email { get; set; }
        public string LockerNumber { get; set; }
        public string GenericPassword { get; set; }
        public void GetPersonalDetails()
        {
            Console.WriteLine("Enter the Email,Locker Info, GenericPassword");
            Email=Console.ReadLine();
            LockerNumber=Console.ReadLine();
            GenericPassword=Console.ReadLine();
            Console.WriteLine("Email: "+ Email);
            Console.WriteLine("Locker Number: "+ LockerNumber);
            Console.WriteLine("Generic password: "+ GenericPassword);
        }
    }
    //public class EmployeeDetails : PersonalDetails
    //{
    // //This will cause a compile-time error because PersonalDetails is sealed\
    //}
}
