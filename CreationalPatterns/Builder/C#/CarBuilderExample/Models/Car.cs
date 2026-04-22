using System;
using System.Collections.Generic;

namespace CarBuilderExample.Models
{
    public class Car
    {
        private string brand;
        private Dictionary<string, string> parts =
            new Dictionary<string, string>();

        public Car(string brand)
        {
            this.brand = brand;
        }

        public string this[string key]
        {
            get => parts[key];
            set => parts[key] = value;
        }

        public void Show()
        {
            Console.WriteLine("\n" + new string('-', 30));
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Engine: {this["engine"]}");
            Console.WriteLine($"Transmission: {this["transmission"]}");
            Console.WriteLine($"Interior: {this["interior"]}");
            Console.WriteLine($"Infotainment: {this["infotainment"]}");
        }
    }
}