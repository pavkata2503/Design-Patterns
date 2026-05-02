using CarOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrderSystem.ChainOfResponsibility
{
    class PaymentHandler : OrderHandler
    {
        public override void Handle(Order order)
        {
            Console.WriteLine($"Processing payment: {order.Price} EUR");
        }
    }
}
