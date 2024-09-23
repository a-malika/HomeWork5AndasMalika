using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class BusFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            Console.Write("Door Number: ");
            int doorNumber = Convert.ToInt32(Console.ReadLine());
            return new Bus(doorNumber);
        }
    }
}
