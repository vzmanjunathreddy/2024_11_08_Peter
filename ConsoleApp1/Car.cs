using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car : IVehicle
    {
        public string Model { get; set; }
        public string Make { get; set; }

        public string GetVehicleType()
        {
            return "Car";
        }

        public void PrintVehicleDetails()
        {
            Console.WriteLine($"this is a {GetVehicleType()}");
        }
    }
}
