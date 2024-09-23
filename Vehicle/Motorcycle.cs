using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Motorcycle : IVehicle
    {
        public string Type { get; set; }
        public double EngineDisplacement { get; set; }
        public Motorcycle() { }
        public Motorcycle(string type, double engineDisplacement)
        {
            Type = type;
            EngineDisplacement = engineDisplacement;
        }
        public void Drive()
        {
            Console.WriteLine("The motorcycle is drived.");
        }
        public void Refuel()
        {
            Console.WriteLine("The motorcycle is refueling.");
        }
    }
}
