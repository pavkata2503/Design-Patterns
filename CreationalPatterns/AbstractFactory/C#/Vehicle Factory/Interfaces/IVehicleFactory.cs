using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle CreateSedan();
        IVehicle CreateSUV();
        IVehicle CreateSportsCar();
    }
}
