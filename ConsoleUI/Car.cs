using System;
namespace ConsoleUI
{
    public class Car :Vehicle
    {

        public override void DriveAbstract()
        {
            Console.WriteLine("I am driving my car.");
        }
        

        public bool HasTrunk { get; set; } = true;
        public bool Has4Wheels { get; set; } = true;

        public Car()
        {
        }
    }
}
