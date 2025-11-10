using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethod_Demo
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle : run for pre-run checks");
        }
    }
    public class Car : Vehicle
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("Car : Start with key");
        }
    }
    public class ElectricCar : Car
    {
        public sealed override void Start()
        {
            base.Start();
            Console.WriteLine("ElectricCar : start with button");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricCar myElectricCar = new ElectricCar();
            myElectricCar.Start();
            Console.ReadLine();
        }
    }
}
