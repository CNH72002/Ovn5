using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5.ConcreteClass
{
    public class Boat:Vehicle
    {

        private int noOfSpike;

        public int NoOfSpike
        {
            get { return noOfSpike; }
            set
            {
                if (value > 0)
                {
                    noOfSpike = value;
                }
                else
                {
                    noOfSpike = 0;
                }

            }
        }



        public Boat(string name, string regNo, string color) : base(name, regNo, color)
        {
            NoOfSpike = noOfSpike;   //initial value

        }



        public override string ToString()
        {
            string strOut = base.ToString();

            strOut = $"\n Number of Spikes : {NoOfSpike} ";

            return strOut;

        }

    }
}
