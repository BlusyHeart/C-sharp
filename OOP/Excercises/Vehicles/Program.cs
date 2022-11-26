using MotorVehicles.Core;
using MotorVehicles.Factories;
using MotorVehicles.Factories.Interfaces;
using MotorVehicles.IO;
using MotorVehicles.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Vehicles.Models;

namespace StreeRacing
{
    class StartUp
    {
        static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            string[] carInput = reader.ReadLine().Split();

            string[] truckInput = reader.ReadLine().Split();

            string[] busInput = reader.ReadLine().Split();

            IVehicleFactory vehicleFactory = new VehicleFactory();

            Vehicle car = 
                vehicleFactory.CreateVehicle(carInput[0], double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));
            Vehicle truck =
                vehicleFactory.CreateVehicle(truckInput[0], double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(carInput[3]));
            Vehicle bus =
                vehicleFactory.CreateVehicle(busInput[0], double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));

            IEngine engine = new Engine(car, truck, bus,  reader, writer);
            engine.Start();
        }
    }
}

