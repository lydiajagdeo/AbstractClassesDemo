using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {

        public int Year { get; set; } = 2007;
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Nitro";

        public abstract void DriveAbstract();


        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}

