using System;
using Ovn5.ConcreteClass;

namespace Ovn5
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserClass obj = new UserClass();
            //obj.Start();


            var gh = new GarageHandler2(10);
            gh.SeedData();
            gh.Park(new Car("TEST", "TEST", "TEST", 0));
            gh.Unpark("TEST");
            gh.Unpark("TEST");
            gh.PrintAllVehicles();


        }
    }
}
