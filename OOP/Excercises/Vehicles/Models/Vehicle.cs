using MotorVehicles.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQunatity;
        private double fuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; protected set; }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set ; }

        public string Drive(double distance)
        {
            if (FuelQuantity >= distance * FuelConsumption)
            {
                FuelQuantity -= distance * FuelConsumption;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public virtual string Drive(double distance, bool isAirConditionOn)
        {
            return "";
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (FuelQuantity + fuel > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                FuelQuantity += fuel;
            }
            
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
