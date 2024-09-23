using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class MotorcycleFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.Write("Type: ");
            string brand = Console.ReadLine();
            Console.Write("Engine Displacement: ");
            double engineDisplacement = Convert.ToDouble(Console.ReadLine());
            return new Motorcycle(brand, engineDisplacement);
        }
    }
}
