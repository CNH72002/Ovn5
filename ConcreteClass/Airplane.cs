using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5.ConcreteClass
{
    public class Airplane: Vehicle
    {

         public double LenghtAirPlane { get; set; }


        public Airplane(string name, string regNo, string color, double lenghtOfAirPlane) : base(name, regNo, color)
        {
           LenghtAirPlane = lenghtOfAirPlane;   //initial value

        }


        public override string ToString()
        {
  
            string strOut = base.ToString() + $" Airplane Lenght : {LenghtAirPlane} ";

            return strOut;

        }





    }
}
