using System;
using System.Security.Permissions;
using VehicleTesterSimulator.Entities.Interfaces;
using static VehicleTesterSimulator.Common.Enums.Enumerator;


namespace VehicleTesterSimulator.Entities.Classes.Vehicles
{
    internal class Car<T>:Vehicle<T>, IEngineFuel, IEngineElectric
    {
        public int Doors { get; set; }
        public int Model { get; set; }
        public float FuelLevel {  get; set; }
        //public EngineType Type { get; set; }
        public FuelType FuelType { get; set; }

        public float BatteryLevel {get ; set; }

        public Car(string brand, int doors, int model): base(brand)
        {
            Doors = doors;
            Model = model;
        }

        public override void Acelerate()
        {
            Speed += 10;
            Console.WriteLine($"El auto {Brand} ha acelerado a {Speed} Km/h.");
        }
        public void Acelerate(int increment)
        {
            Speed += increment;
            Console.WriteLine($"El auto {Brand} ha acelerado a {Speed} Km/h.");
        }

        public void ChargeBattery()
        {
            BatteryLevel = 100;
            Console.WriteLine("La batería está completamente Cargada");
        }
        public void FuelFill()
        {
            // FuelLevel = 100;
            Console.WriteLine($"El auto {Brand} ha sido rellenado con {FuelType}.");
        }
    }
}
