using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IVehicle
    {
        public string Model { get; set; }
        public string Make { get; set; }

        string GetVehicleType();
        void PrintVehicleDetails();
    }
}
