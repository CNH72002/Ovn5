using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5.ConcreteClass
{
    public class Bus: Vehicle
    {


        private int noOfSeat;

        public int NoOfSeats
        {
            get { return noOfSeat; }
            set
            {
                if (value > 0)
                {
                    noOfSeat = value;
                }
                else
                {
                    noOfSeat = 0 ;
                }

            }
        }



        public Bus(string name, string regNo, string color) : base(name, regNo, color)
        {
            NoOfSeats = noOfSeat;   //initial value

        }



        public override string ToString()
        {
            string strOut = base.ToString();

            strOut = $"\n Number of seats : {NoOfSeats} ";

            return strOut;

        }

    }
}
