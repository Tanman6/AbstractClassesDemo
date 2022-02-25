using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {

        public override void DriveAbstract()
        {
            Console.WriteLine("I am driving my motorcycle.");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }

        public bool HasSideCart { get; set; } = false;
        public bool Has2Wheels { get; set; } = true;

        public Motorcycle()
        {
        }
    }
}
