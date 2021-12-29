using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn5
{
    public class Utilities
    {

        public static int ReadSelection()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Select an operation): ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if ((choice > 0) && (choice <= 4))  // Check if the converted integer lies within 1 -3 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }






        public static int ReadVehicleType()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Select the vehicle type:");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if ((choice >= 0) && (choice <= 5))  // Check if the converted integer lies within 0 and 5 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }



        public static int ReadInteger()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Airplane lenght:");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if (choice > 0)  // Check if the converted integer lies within 1 -3 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }


        public static int ReadInteger2()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Number of Seat: ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if (choice > 0)  // Check if the converted integer lies within 1 -3 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }


        public static int ReadInteger3()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Number of spikes: ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if (choice > 0)  // Check if the converted integer lies within 1 -3 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }










        public static double ReadDouble()
        {
            bool validNum = false; // valid number initially set to zero
            double choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Car Cylinder volume: ");  // User input to the Menu choice requested
                                                                   // Console.WriteLine();
                string strInput = Console.ReadLine();  
                validNum = double.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if (choice >= 0.0)  // Check if the converted integer lies above zero inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again. \n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }





    }
}
