using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyApp_Assignment
{
    internal class Ride
    {
        public Customer Customer;
        public Vehicle Vehicle;
        public decimal DistanceKm;
        public DateTime RideDate;

        public Ride(Customer customer, Vehicle vehicle, decimal distanceKm, DateTime date)
        {
            Customer = customer;
            Vehicle = vehicle;
            DistanceKm = distanceKm;
            RideDate = date;
        }

        public void ComputeBill(out decimal subtotal, out decimal gst, out decimal total, params string[] addOns)
        {
            // ✅ Check spelling: Vehicle.PerKmRate (capital P, capital K, capital R)
            decimal rideCost = Vehicle.BaseFare + (Vehicle.PerKmRate * DistanceKm);

            decimal addons = Pricing.AddOnsCost(addOns);

            subtotal = rideCost + addons;

            // ✅ Pricing.TryGetWeekendSurcharge must exist in Pricing.cs
            if (Pricing.TryGetWeekendSurcharge(RideDate, out decimal percent))
            {
                subtotal += subtotal * percent;
            }

            gst = Pricing.CalculateGST(subtotal);
            total = subtotal + gst;
        }

    }
}
