using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Truck : IVehicle
    {
        public string LoadCapacity { get; set; }
        public int NumberOfAxels { get; set; }
        public Truck() { }
        public Truck(string loadCapacity, int numberOfAxels)
        {
            LoadCapacity = loadCapacity;
            NumberOfAxels = numberOfAxels;
        }
        public void Drive()
        {
            Console.WriteLine("The truck is drived.");
        }
        public void Refuel()
        {
            Console.WriteLine("The truck is refueling.");
        }
    }
}
