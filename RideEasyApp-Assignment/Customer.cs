using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyApp_Assignment
{
    internal class Customer
    {
        public string Name;
        public string Mobile;
        public int LoyaltyPoints;

        public Customer(string name,string mobile,int loyaltypoints) 
        {
            Name = name;
            Mobile = mobile;
            LoyaltyPoints = loyaltypoints;
        }
    }
}
