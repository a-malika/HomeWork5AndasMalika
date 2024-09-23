using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork5
{
    internal class Car : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public Car() { }
        public Car(string brand, string model, string fuelType)
        {
            Brand = brand;
            Model = model;
            FuelType = fuelType;
        }

        public void Drive()
        {
            Console.WriteLine("The car is drived.");
        }
        public void Refuel()
        {
            Console.WriteLine("The car is refueling.");
        }
    }
}
