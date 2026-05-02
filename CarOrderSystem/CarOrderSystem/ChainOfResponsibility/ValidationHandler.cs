using CarOrderSystem.Models;
using CarOrderSystem.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrderSystem.ChainOfResponsibility
{
    class ValidationHandler : OrderHandler
    {
        public override void Handle(Order order)
        {
            Console.WriteLine("Validating order...");

            if (order == null)
            {
                Logger.Error("Order is null!");
                return;
            }

            if (order.Price <= 0)
            {
                Logger.Error("Invalid price!");
                return;
            }

            if (order.Price > 100000)
            {
                Logger.Warning("High value order - requires approval!");
            }


            next?.Handle(order);
        }
    }
}
