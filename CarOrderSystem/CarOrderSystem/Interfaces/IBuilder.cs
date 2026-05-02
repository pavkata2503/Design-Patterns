using CarOrderSystem.Composite;
using System;
using System.Collections.Generic;
using System.Text;
using CarOrderSystem.Composite;

namespace CarOrderSystem.Interfaces
{
    public interface IBuilder
    {
        IBuilder AddEngine();
        IBuilder AddWheels();
        IBuilder AddLuxuryPackage();

        CarComposite Build();
    }
}
