using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5
{
    public abstract class Vehicle: IVehicle
    {
        private string name;
        private string registrNo;
        private string color;
      

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string RegNo
        {
            get { return registrNo; }
            set { registrNo = value; }
        }


        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        



        public Vehicle(string name, string color, string regNo)
        {
            //Initializations
            Name = name;
            Color = color;
            RegNo= regNo;
           
           
        }


        public override string ToString()
        {
            string strOut = $"Name : {Name},  Vehicle Reg. No : {RegNo}, Color: {Color} ";

            return strOut;
        }






    }
}
