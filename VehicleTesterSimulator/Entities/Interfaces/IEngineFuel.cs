using System;
using static VehicleTesterSimulator.Common.Enums.Enumerator;


namespace VehicleTesterSimulator.Entities.Interfaces
{
    internal interface IEngineFuel
    {
        FuelType FuelType { get; set; }


        void FuelFill();
    }
}
