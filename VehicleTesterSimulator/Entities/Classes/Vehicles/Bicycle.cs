using System;
using VehicleTesterSimulator.Entities.Interfaces;


namespace VehicleTesterSimulator.Entities.Classes.Vehicles
{
    internal class Bicycle<EngineElectric> : Vehicle<EngineElectric>,IEngineElectric
    {
        public int Model {  get; set; }
        public float BatteryLevel {  get; set; }

        public Bicycle(String brand, int model) : base(brand)
        {

        }
        public override void Acelerate()
        {
            Speed += 5;
            Console.WriteLine($"La bicicleta {Brand} ha acelerado a {Speed} Km/h.");
        }

        public void ChargeBattery()
        {
            BatteryLevel = 100;
            Console.WriteLine("La batería de la Bicicleta está completamente Cargada");
        }
    }
}
