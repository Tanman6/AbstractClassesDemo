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
            var vehicles = new List<Vehicle>();
            var car1 = new Car { Year = "2015", Make = "Volkswagen", Model = "Jetta", HasTrunk = true, Has4Wheels = true };
            var motorcycle1 = new Motorcycle{ Year = "2010", Make = "Kawasaki", Model = "Ninja", HasSideCart = false };
            Vehicle car2 = new Car { Year = "2016", Make = "Tesla", Model = "Model X", HasTrunk = true, Has4Wheels = true };
            Vehicle motorcycle2 = new Motorcycle { Year = "2012", Make = "Honda", Model = "RCB1000", HasSideCart = false };

            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motorcycle1);
            vehicles.Add(motorcycle2);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
                item.DriveAbstract();
                item.DriveVirtual();
                Console.WriteLine();
            }
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

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
