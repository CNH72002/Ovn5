using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5
{
    public class Garage<Vehicle> :IEnumerable<Vehicle> 
    {
        
        #region

        private Vehicle[] garage;
        public Garage( Vehicle [] pArray)
        {
            garage = new Vehicle[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                garage[i] = pArray[i];
            }
        }

        public Vehicle[] Garage1
        {
            get { return garage; }
            set { garage = value; }
        }





        //xxxxxxxxxxxxxxxxxxxxx
        // Implementation for the GetEnumerator method.

        IEnumerator<Vehicle> IEnumerable<Vehicle>.GetEnumerator()
        {
            return (IEnumerator<Vehicle>)GetEnumerator();
        }

       

        public VehicleEnumerator GetEnumerator()
        {
            return new VehicleEnumerator(garage);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return new VehicleEnumerator(garage);
        }


        #endregion
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx



        // When you implement IEnumerable, you must also implement IEnumerator.
        public class VehicleEnumerator : IEnumerator
        {
            public Vehicle[] _garage;

            // Enumerators are positioned before the first element
            // until the first MoveNext() call.
            int position = -1;

            public VehicleEnumerator(Vehicle[] list)
            {
                _garage = list;
            }

            public bool MoveNext()
            {
                position++;
                return (position < _garage.Length);
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public Vehicle Current
            {
                get
                {
                    try
                    {
                        return _garage[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }


        }


        
        /// <summary>
        /// Method to generate unique ID of the vehicle object
        /// </summary>
        public string SetNewID()
        {

            const string startID = "ABC";
            return $"{startID}{Count + 1}";

        }


        public int Count
        {

            get
            {
                if (garage != null)
                {
                    return garage.Length;
                }
                else
                {
                    return 0;
                }
            }
        }

        #region
        //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

        public bool Add(Vehicle veh)
        {
            int index = FindVacantPositionR();    // Check the array to see if an index has a vacant element.
            bool success = false;    //initialization


            if (index >= 0)      // if the found index from the search is greater or equal to zero.
            {
                garage[index] = veh;   // Reset the value in that index to the value "newRecipe"
                success = true;          // Set success to true.
            }

            return success;      // Return the value of  success.

        }    // end Add method




        public bool ChangeElement(int index, Vehicle veh)
        {
            bool bok = true;   //initialization of a local variable
            if (CheckIndex(index))   // check index validity if its not null
            {
                garage[index] = veh;  
            }
            else             //otherwise
                bok = false;    //set the local varaible to false.

            return bok;   //return the value of this local varaible.

        }


        public bool DeleteElement(int index)
        {
            bool bok = true;   // initialization of the local varaible.
            if (CheckIndex(index))    // check for validity
            {
                garage[index] = default;    // reset the value to null at this index.
            }
            else
                bok = false;

            return bok;    // return false or true depending on the program

        }



        public int GetCurrentNumOfItems()
        {
            int count = 0;    // initialization to zero.

            for (int index = 0; index < garage.Length; index++)   // for loop.
            {
                if (garage[index] != null)   // the control block for the check
                    count++;         // incremental count by 1
            }

            return count;    // return count
        }



        public bool CheckIndex(int index)
        {
            bool ok = false;   // initialization

            bool ok1 = (index >= 0) && (index < garage.Length);  //Check if index is within 0 and less than array lenght by 1
            if (ok1)
            {
                ok = true;   // set ok to true.
            }
            return ok;     // return true or false depending on the checks
        }


        
        public Vehicle GetRecipeAt(int index)
        {
            if (CheckIndex(index))    // check if index is valid
                return garage[index];
            else
                return default;

        }



        private int FindVacantPositionR()
        {
            for (int index = 0; index < garage.Length; index++)
            {

                if (garage[index] == null)    //Control to check if any array index is null
                {
                    return index;  // return the index.           
                }

            }
            return -1;   //return -1 otherwise.
        }



        #endregion


    }
}
