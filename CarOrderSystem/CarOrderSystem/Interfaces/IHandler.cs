using CarOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrderSystem.Interfaces
{ public interface IHandler
        {
            void SetNext(IHandler handler);
            void Handle(Order order);
        }
    
}
