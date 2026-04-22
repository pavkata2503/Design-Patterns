using CarBuilderExample.Models;

namespace CarBuilderExample.Builders
{
    public class TeslaBuilder : CarBuilder
    {
        public TeslaBuilder()
        {
            Car = new Car("Tesla");
        }

        public override void BuildEngine()
        {
            Car["engine"] = "Electric Motor";
        }

        public override void BuildTransmission()
        {
            Car["transmission"] = "Single Speed";
        }

        public override void BuildInterior()
        {
            Car["interior"] = "Minimalist Interior";
        }

        public override void BuildInfotainment()
        {
            Car["infotainment"] = "Tesla Touchscreen";
        }
    }
}