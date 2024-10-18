using System;


namespace VehicleTesterSimulator.Entities.Interfaces
{
    internal interface IEngineElectric
    {
        float BatteryLevel { get; set; }

        public void ChargeBattery();
    }
}
