using System;


namespace VehicleTesterSimulator.Entities.Classes.Vehicles.Part
{
    internal class Engine
    {
        public float EnginePower {  get; set; }
        public Engine() { }

        public void TurnOn()
        {
            Console.WriteLine("Motor encendido");
        }
        public void TurnOff()
        {
            Console.WriteLine("Motor apagado");
        }
    }
}
