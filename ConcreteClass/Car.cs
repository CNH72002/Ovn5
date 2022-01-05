using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5.ConcreteClass
{
    public class Car : Vehicle
    {

        private double cylinderVol;

        public double CylinderVol
        {
            get { return cylinderVol; }
            set
            {
                if (value > 0)
                {
                    cylinderVol = value;
                }
                else
                {
                    cylinderVol = 0.0;
                }

            }
        }



        public Car(string name, string regNo, string color, double cylinderVol) : base(name, regNo, color)
        {
            CylinderVol = cylinderVol;   //initial value

        }



        public override string ToString()
        {
            string strOut = base.ToString() + $", Cylinder Vol : {CylinderVol} ";


            return strOut;

        }

    }
}
