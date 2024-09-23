using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Fuel Type: ");
            string fuelType = Console.ReadLine();
            return new Car(brand, model, fuelType);
        }
    }
}
