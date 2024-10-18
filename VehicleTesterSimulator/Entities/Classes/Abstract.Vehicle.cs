using System;


namespace VehicleTesterSimulator.Entities.Classes
{
    internal abstract class Vehicle<T>
    {
        public float Speed { get; set; }
        public string Brand { get; private set; }
        public required T Engine { get; set; }

        protected Vehicle(string Brand) {
            Brand = Brand;
        }

        public abstract void Acelerate();
        public virtual void Decelerate()
        {
            Console.WriteLine("El vehiculo desaceleró");
        }

    }
}
