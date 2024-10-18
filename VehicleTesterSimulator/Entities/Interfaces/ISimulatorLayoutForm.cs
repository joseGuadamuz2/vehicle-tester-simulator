using System;
using static VehicleTesterSimulator.Common.Enums.Enumerator;

namespace VehicleTesterSimulator.Entities.Interfaces
{
    internal interface ISimulatorLayoutForm
    {
       public void SetResources();

       public void SetCulture(Language language);
    }
}
