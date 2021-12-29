using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5.ConcreteClass
{
    public class Airplane: Vehicle
    {

        private double lenghtOfAirPlane;

        public double LenghtAirPlane
        {
            get { return lenghtOfAirPlane; }
            set
            {
                if (value > 0.0)
                {
                    lenghtOfAirPlane = value;
                }
                    
            }
        }

       

        public Airplane(string name, string regNo, string color) : base(name, regNo, color)
        {
           LenghtAirPlane = lenghtOfAirPlane;   //initial value

        }



        public override string ToString()
        {
            string strOut = base.ToString();

            // strOut += String.Format(": {0}.", breed );
            strOut = $"\n Airplane Lenght : {LenghtAirPlane} ";

            return strOut;

        }





    }
}
