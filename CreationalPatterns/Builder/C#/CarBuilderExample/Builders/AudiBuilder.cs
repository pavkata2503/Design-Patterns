using CarBuilderExample.Models;

namespace CarBuilderExample.Builders
{
    public class AudiBuilder : CarBuilder
    {
        public AudiBuilder()
        {
            Car = new Car("Audi");
        }

        public override void BuildEngine()
        {
            Car["engine"] = "2.0 TFSI";
        }

        public override void BuildTransmission()
        {
            Car["transmission"] = "S-Tronic";
        }

        public override void BuildInterior()
        {
            Car["interior"] = "Premium Interior";
        }

        public override void BuildInfotainment()
        {
            Car["infotainment"] = "Virtual Cockpit";
        }
    }
}