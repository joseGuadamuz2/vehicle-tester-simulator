using System;
using VehicleTesterSimulator.Entities.Interfaces;
using static VehicleTesterSimulator.Common.Enums.Enumerator;


namespace VehicleTesterSimulator.Entities.Classes.Vehicles
{
    internal class Motorcycle<T>: Vehicle<T>,IEngineFuel
    {
        public EngineType Type { get; set; }
        public FuelType FuelType { get; set; }

        public Motorcycle(string brand):base(brand)
        {

        }
        public override void Acelerate()
        {
            Speed += 15;
            Console.WriteLine($"La moto {Brand} ha acelerado a {Speed} Km/h.");
        }

        public void FuelFill()
        {
            // FuelLevel = 100;
            Console.WriteLine($"La moto {Brand} ha sido rellenada con {FuelType}.");
        }
    }
}
