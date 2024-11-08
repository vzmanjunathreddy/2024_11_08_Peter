// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
//Design a system using the Factory Design Pattern that can produce different types of vehicles
//such as Car, Truck, and Motorcycle. The goal is to allow a user to request a specific type
//of vehicle (e.g., "Car", "Truck") and receive an appropriate instance without directly
//creating the object.
//The client should not need to know the details of how the vehicle is created.
var factory= new VehicleFactory();

var vehicle1 = factory.CreateVehicle("Car");
var vehicle2 = factory.CreateVehicle("Truck");
var vehicle3 = factory.CreateVehicle("Motorcycle");

vehicle1.PrintVehicleDetails();
vehicle2.PrintVehicleDetails();
vehicle3.PrintVehicleDetails();

class VehicleFactory
{
    public IVehicle CreateVehicle(string type)
    {
        if (string.IsNullOrEmpty(type))
        {
            throw new ArgumentNullException("type");
        }
        if (type == "Car")
        {
            return new Car();
        }
        if (type == "Truck")
        {
            return new Truck();
        }

        if (type == "Motorcycle")
        {
            return new Motorcycle();
        }

        throw new InvalidOperationException($"Type:{type} not supported");
    }
}