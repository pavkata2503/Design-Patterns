using CarOrderSystem.Models;
using CarOrderSystem.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrderSystem.ChainOfResponsibility
{
    class DiscountHandler : OrderHandler
    {
        public override void Handle(Order order)
        {
            Console.WriteLine("Applying discount...");
            double originalPrice = order.Price;

            if (order.Price > 10000)
            {
                order.Price *= 0.9;
                Logger.Info("Applied 10% discount for high price");
            }

            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                order.Price *= 0.97;
                Logger.Info("Applied Friday discount");
            }

            Logger.Info($"Final price after discounts: {order.Price}");

            next?.Handle(order);
        }
    }
}
