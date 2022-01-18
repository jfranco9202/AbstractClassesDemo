using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var focus = new Car() {HasTruck = true, Make = "Ford", Model = "Focus", Year = 2019};
            var mortorcyle = new Motorcyle() { HasSideCart = true, Make = "Harley Davidson", Model = "cobra", Year = 2017 };

            Vehicle sedan = new Car() {HasTruck = true, Make = "Dodge", Model = "blah", Year = 2015 };
            Vehicle Civic = new Car() { HasTruck = true, Make = "Honda", Model = "civic", Year = 2017 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(focus);
            vehicles.Add(mortorcyle);
            vehicles.Add(sedan);
            vehicles.Add(Civic);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make} Model {veh.Model} Year {veh.Year}");
                veh.DriveAbstract();
            }



            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}
