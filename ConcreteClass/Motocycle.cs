using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5.ConcreteClass
{
    public class Motocycle : Vehicle
    {

        private string fuelType;

        public string FuelType
        {
            get { return fuelType; }
            set
            {
                if (value != string.Empty)
                {
                    fuelType = value;
                }
                else
                {
                    fuelType = "Normal";
                }

            }
        }



        public Motocycle(string name, string regNo, string color, string fuelType) : base(name,regNo, color)
        {
            FuelType = fuelType;   //initial value

        }



        public override string ToString()
        {
            string strOut = base.ToString() + $" Fuel Type : {FuelType} ";

            return strOut;

        }







    }
}
