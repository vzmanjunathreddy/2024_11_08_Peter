using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Truck : IVehicle
    {
        public string Model { get; set; }
        public string Make { get; set; }

        public string GetVehicleType()
        {
            return "Truck";
        }

        public void PrintVehicleDetails()
        {
            Console.WriteLine($"This is a {GetVehicleType()}");
        }
    }
}
