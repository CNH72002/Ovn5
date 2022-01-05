using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5
{
    public abstract class Vehicle : IVehicle
    {

        public string Name { get; set; }
        public string RegNo  { get; set; }
        public string Color { get; set; }


        public Vehicle(string name, string color, string regNo)
        {
            //Initializations
            Name = name;
            Color = color;
            RegNo= regNo;
           
        }


        public override string ToString()
        {
            string strOut = $"Type : {this.GetType().Name}, Name : {Name},  Vehicle Reg. No : {RegNo}, Color: {Color} ";

            return strOut;
        }






    }
}
