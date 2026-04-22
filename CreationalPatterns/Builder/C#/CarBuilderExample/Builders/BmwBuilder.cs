using CarBuilderExample.Models;

namespace CarBuilderExample.Builders
{
    public class BmwBuilder : CarBuilder
    {
        public BmwBuilder()
        {
            Car = new Car("BMW");
        }

        public override void BuildEngine()
        {
            Car["engine"] = "3.0L Twin Turbo";
        }

        public override void BuildTransmission()
        {
            Car["transmission"] = "8-speed Automatic";
        }

        public override void BuildInterior()
        {
            Car["interior"] = "Leather Sport Interior";
        }

        public override void BuildInfotainment()
        {
            Car["infotainment"] = "iDrive System";
        }
    }
}