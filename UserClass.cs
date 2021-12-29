using Ovn5.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5
{
    public class UserClass 
    {
        private Vehicle[] myarray = new Vehicle[20];
        private static Garage<Vehicle> obj;

        public UserClass( )
        {
            obj = new Garage<Vehicle>(myarray); 

        }

        private int choosedInput;  // Menu class instance variable

        #region
        public void Start()  // Start Menu method.
        {
            int choice = -1;   // set the initial out value to -1.

            while (choice != 0)     //While loop to ensure that this loop terminates if the user input is zero (0).
            {
                WriteMenuText();  // Displays the first Menu.

                choice = Utilities.ReadSelection();  // Read the input to the Main Menu and assign value to variable choice.

                choosedInput = choice;  // The out variable from the method ReadInputChoice() assigned to variable  
                                        // choosedInput.

                CurrentOperationMenu();  // This method displays the current operation choosed

            }

        }


        private void CurrentOperationMenu()    // All the operations for this Application is selected here
        {
            switch (choosedInput)   // The switch block used the choosedInput as variable for the check.
            {
                case 0:
                    Environment.Exit(0); // Call this to exit program.
                    break;

                case 1:
                    CreateVehicle();  // Call this method for youth, pensionare and group
                    break;

                case 2:
                   // RepeatInputTenTimes(); // Call this method to reapeat and inpt 10 times
                    break;

               

                default:
                    Console.WriteLine("Wrong choice try again!");   // default if no right choice was made
                    break;

            }

        }



        private static void CreateVehicle()
        {
            do
            {
                VehicleType();

            } while (userResponse != 0);
           

        }


        public static Vehicle CreateAirplane()
        {
            Console.Write("Enter the name of the airplain  ");
            string strName = Console.ReadLine();
            Console.Write("Enter the regNo: ");
            string strRegNo = Console.ReadLine();
            Console.Write("What is the airplain color :");
            string strColor = Console.ReadLine();
            int lenght = Utilities.ReadInteger();

            Vehicle airplain = new Airplane(strName, strRegNo, strColor);
            

            ((Airplane)airplain).LenghtAirPlane = lenght;

            return airplain;



        }



        private static void WriteMenuText()  // This method displays the first main Menu.
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("                  MAIN MENU                   ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     Exit the program                        :0");
            Console.WriteLine("     Create  vehicle types                   :1");
            Console.WriteLine("----------------------------------------------");



        }

        private static int userResponse;
        private static void VehicleType()
        {

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("                  SUB-MENU                   ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     Exit                                        :0");
            Console.WriteLine("     Create Airplane                             :1");
            Console.WriteLine("     Create Motocycle                            :2");
            Console.WriteLine("     Create Car                                  :3");
            Console.WriteLine("     Create Bus                                  :4");
            Console.WriteLine("     Create Boat                                 :5");
            Console.WriteLine("----------------------------------------------");

            userResponse = Utilities.ReadVehicleType();

            switch (userResponse)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Vehicle airplain = CreateAirplane();
                    obj.Add(airplain);

                    break;
                case 2:
                    Vehicle motocycle = CreateMotorCycle();
                    obj.Add(motocycle);
                    break;
                case 3:
                    //Create a Car
                    Vehicle car = CreateCar();
                    obj.Add(car);
                    break;
                case 4:
                    Vehicle bus = CreateBus();
                    obj.Add(bus);
                    break;
                case 5:
                    Vehicle boat = CreateBoat();
                    obj.Add(boat);
                    break;




            }

            Console.WriteLine($" The number of item is {obj.GetCurrentNumOfItems()}");

            


        }

        private static Vehicle CreateBoat()
        {
            Console.Write("Enter the name of the Boat  ");
            string strName = Console.ReadLine();
            Console.Write("Enter the regNo: ");
            string strRegNo = Console.ReadLine();
            Console.Write("What is the boat color : ");
            string strColor = Console.ReadLine();
            int strNoOfSpikes = Utilities.ReadInteger3();

            Vehicle boat = new Boat(strName, strRegNo, strColor);


            ((Boat)boat).NoOfSpike = strNoOfSpikes;

            return boat;

        }

        private static Vehicle CreateBus()
        {
            Console.Write("Enter the name of the bus  ");
            string strName = Console.ReadLine();
            Console.Write("Enter the regNo: ");
            string strRegNo = Console.ReadLine();
            Console.Write("What is the bus color : ");
            string strColor = Console.ReadLine();
            int  strNoOfSeats = Utilities.ReadInteger2();

            Vehicle bus = new Bus(strName, strRegNo, strColor);


            ((Bus)bus).NoOfSeats = strNoOfSeats;

            return bus;


        }

        private static Vehicle CreateCar()
        {
            Console.Write("Enter the name of the car  ");
            string strName = Console.ReadLine();
            Console.Write("Enter the regNo: ");
            string strRegNo = Console.ReadLine();
            Console.Write("What is the car color : ");
            string strColor = Console.ReadLine();
            double strCylinderVol = Utilities.ReadDouble();

            Vehicle car = new Car(strName, strRegNo, strColor);


            ((Car)car).CylinderVol = strCylinderVol;

            return car;




        }

        private static Vehicle CreateMotorCycle()
        {
            Console.Write("Enter the name of Motorcycle  ");
            string strName = Console.ReadLine();
            Console.Write("Enter the regNo: ");
            string strRegNo = Console.ReadLine();
            Console.Write("What is the Motorcycle color :");
            string strColor = Console.ReadLine();
            Console.Write("What is the Motorcycle fuel type :");
            string strFuetype = Console.ReadLine();

            Vehicle motocycle = new Motocycle(strName, strRegNo, strColor);

            ((Motocycle)motocycle).FuelType = strFuetype;

            return motocycle;




        }
        #endregion
    }
}
