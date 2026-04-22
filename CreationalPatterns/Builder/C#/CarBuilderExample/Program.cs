using System;
using CarBuilderExample.Builders;
using CarBuilderExample.Director;

namespace CarBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new CarFactory();

            CarBuilder builder = new BmwBuilder();
            factory.Construct(builder);
            builder.Car.Show();

            builder = new AudiBuilder();
            factory.Construct(builder);
            builder.Car.Show();

            builder = new TeslaBuilder();
            factory.Construct(builder);
            builder.Car.Show();

            Console.ReadKey();
        }
    }
}