using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Bus : IVehicle
    {

        public int DoorNumber { get; set; }
        public Bus() { }
        public Bus(int doorNumber)
        {
            DoorNumber = doorNumber;
        }
        public void Drive()
        {
            Console.WriteLine("The bus is drived.");
        }
        public void Refuel()
        {
            Console.WriteLine("The bus is refueling.");
        }
    }
}
