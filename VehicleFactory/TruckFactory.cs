using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class TruckFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.Write("Load Capacity: ");
            string loadCapacity = Console.ReadLine();
            Console.Write("Number Of Axels: ");
            int numberOfAxels = Convert.ToInt32(Console.ReadLine());
            return new Truck(loadCapacity, numberOfAxels);
        }
    }
}
