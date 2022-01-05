using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5
{
    public class Garage2<T> : IEnumerable<T> where T : IVehicle
    {

        private T[] vehicles;

        public Garage2(int capacity)
        {
            vehicles = new T[capacity];
        }



        public bool Park(T vehicle)
        {

            bool success = false;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    success = true;
                    break;
                }
            }

            return success;
        }

        public bool Unpark(string regnr)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null && vehicles[i].RegNo == regnr)
                {
                    vehicles[i] = default(T);
                    return true;
                }
            }
            return false;
        }



        // Vad händer när vi gör foreach på en instans av Garage2 (och låter oss göra LINQ grejer)
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    yield return vehicle;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
