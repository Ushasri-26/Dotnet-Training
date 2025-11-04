using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyApp_Assignment
{
    class Vehicle
    {
        public string Type;
        public decimal BaseFare;
        public decimal PerKmRate;

        public Vehicle(string type,decimal baseFare, decimal perKmrate)
        {
            Type = type;
            BaseFare = baseFare;
            PerKmRate = perKmrate;
        }
    }
}
