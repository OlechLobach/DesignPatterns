using System;
using TransportFactory.Factories;

namespace TransportFactoryMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a car:");
         
            ITransportFactory carFactory = new CarFactory();

            var car = carFactory.CreateTransport();

    
            Console.WriteLine($"Car: {car.GetInfo()}");

            Console.WriteLine("\nCreating a motorcycle:");

            ITransportFactory motorcycleFactory = new MotorcycleFactory();


            var motorcycle = motorcycleFactory.CreateTransport();


            Console.WriteLine($"Motorcycle: {motorcycle.GetInfo()}");

            Console.WriteLine("\nCreating a bicycle:");

            ITransportFactory bicycleFactory = new BicycleFactory();


            var bicycle = bicycleFactory.CreateTransport();

            Console.WriteLine($"Bicycle: {bicycle.GetInfo()}");
        }
    }
}
