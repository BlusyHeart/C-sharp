using MotorVehicles.IO.Interfaces;
using MotorVehicles.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models;

namespace MotorVehicles.Core
{
    public class Engine : IEngine
    {
        private readonly Vehicle car;
        private readonly Vehicle truck;
        private readonly Vehicle bus;

        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(Vehicle car, Vehicle truck,Vehicle bus, IReader reader, IWriter writer)
        {            
            this.car = car;
            this.truck = truck;
            this.bus = bus;
            this.reader = reader;
            this.writer = writer;
        }

        public void Start()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string command = commandArgs[0];
                string vehicleType = commandArgs[1];
                double number = double.Parse(commandArgs[2]);
                bool isAirConditionOn = false;

                switch (command)
                {
                    case "DriveEmpty":
                        Console.WriteLine(bus.Drive(number));
                        break;

                    case "Drive":
                        switch (vehicleType)
                        {
                            case "Car":
                                Console.WriteLine(car.Drive(number));
                                break;
                            case "Truck":
                                Console.WriteLine(truck.Drive(number));
                                break;
                            case "Bus":
                                isAirConditionOn = true;
                                Console.WriteLine(bus.Drive(number, isAirConditionOn));
                                break;
                        }
                        break;
                    case "Refuel":
                        switch (vehicleType)
                        {
                            case "Car":
                                car.Refuel(number);
                                break;
                            case "Truck":
                                truck.Refuel(number);
                                break;
                            case "Bus":
                                bus.Refuel(number);
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
