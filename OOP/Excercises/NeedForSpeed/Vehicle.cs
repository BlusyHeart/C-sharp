using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    internal class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(double fuel, int horsePower)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public  double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual void Drive(double distance)
        {
            if (Fuel > distance * FuelConsumption)
            {
                Fuel -= distance * FuelConsumption;
            }
        }
    }
}
