using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ovn5.ConcreteClass;

namespace Ovn5
{
    public class GarageHandler2
    {
        private Garage2<IVehicle> garage;

        public GarageHandler2(int capacity)
        {
            garage = new Garage2<IVehicle>(capacity);
        }

        public void PrintAllVehicles()
        {
            foreach (var vehicle in garage)
            {
                Console.WriteLine(vehicle);
                //Console.WriteLine(vehicle.GetType().Name);
            }
        }

        public void SeedData()
        {
            var car1 = new Car("Volvo", "BIL111", "Red", 100);
            var car2 = new Car("Toyota", "BIL222", "Black", 200);
            //var airplan1 = new Airplane("Saab", "AIR111", "White", 100);
            //var boat1 = new Boat("Luxury Brand", "BOA111", "White", 2);
            //var bus1 = new Bus("Mercedes-Benz", "BUS111", "Red", 40);
            //var motorcycle1 = new Motocycle("Suzuki", "MOT111", "Blue", "Petrol");

            garage.Park(car1);
            garage.Park(car2);
            garage.Park(new Airplane("Saab", "AIR111", "White", 100));
            garage.Park(new Boat("Luxury Brand", "BOA111", "White", 2));
            garage.Park(new Bus("Mercedes-Benz", "BUS111", "Red", 40));
            garage.Park(new Motocycle("Suzuki", "MOT111", "Blue", "Petrol"));

        }

        public void Park(Vehicle vehicle)
        {
            if (garage.Park(vehicle))
            {
                Console.WriteLine($"Successfully parked vehicle: {vehicle.RegNo}");
            }
            else
            {
                Console.WriteLine("Garage is full!");
            }
        }

        public void Unpark(string regnr)
        {
            if (garage.Unpark(regnr))
            {
                Console.WriteLine($"Successfully unparked vehicle: {regnr}");
            }
            else
            {
                Console.WriteLine("Vehicle not found!");
            }
            
        }


    }
}
