using CarOrderSystem.Interfaces;
using CarOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrderSystem.ChainOfResponsibility
{
    public abstract class OrderHandler : IHandler
    {
        protected IHandler next;

        public void SetNext(IHandler handler)
        {
            next = handler;
        }

        public abstract void Handle(Order order);
    }
}
