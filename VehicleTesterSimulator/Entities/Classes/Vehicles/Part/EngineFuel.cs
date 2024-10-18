using System;
using static VehicleTesterSimulator.Common.Enums.Enumerator;

namespace VehicleTesterSimulator.Entities.Classes.Vehicles.Part
{
    internal class EngineFuel:Engine
    {
        public FuelType FuelType { get; set; }
        public EngineFuel() { }
        public void Fill() 
        {
            Console.WriteLine("Tanque Cargado");
        }

    }
}
