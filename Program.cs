using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IVehicle MyVehicle;
            VehicleFactory MyVehicleFactory;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("What type of vehicle do you want to create?");
                Console.WriteLine("1 - car, 2 - motorcycle, 3 - truck, 4 - bus.");
                int UserChoice = Convert.ToInt32(Console.ReadLine());
                switch(UserChoice)
                {
                    case 1:
                        MyVehicleFactory = new CarFactory();
                        MyVehicle = MyVehicleFactory.CreateVehicle();
                        break;
                    case 2:
                        MyVehicleFactory = new MotorcycleFactory();
                        MyVehicle = MyVehicleFactory.CreateVehicle();
                        break;
                    case 3:
                        MyVehicleFactory = new TruckFactory();
                        MyVehicle = MyVehicleFactory.CreateVehicle();
                        break;
                    case 4:
                        MyVehicleFactory = new BusFactory();
                        MyVehicle = MyVehicleFactory.CreateVehicle();
                        break;
                    default:
                        throw new Exception("There is not this kind of vehicle.");
                }
                MyVehicle.Drive();
                MyVehicle.Refuel();
            }
        }
    }
}
