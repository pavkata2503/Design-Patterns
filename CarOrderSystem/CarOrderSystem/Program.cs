using CarOrderSystem.Builder;
using CarOrderSystem.ChainOfResponsibility;
using CarOrderSystem.Interfaces;
using CarOrderSystem.Models;

namespace CarOrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder;

            builder = new SUVBuilder();
            // builder = new SedanBuilder();
            // builder = new SportBuilder();

            var car = builder
                .AddEngine()
                .AddWheels()
                .AddLuxuryPackage()
                .Build();


            double price = car.GetPrice();
            Console.WriteLine($"Car price: {price}");


            var validation = new ValidationHandler();
            var discount = new DiscountHandler();
            var payment = new PaymentHandler();

            validation.SetNext(discount);
            discount.SetNext(payment);


            var order = new Order { Price = price };

            validation.Handle(order);
        }
    }
}
