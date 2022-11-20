using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    internal class RaceMotorcycle : Motorcycle
    {
        public const int DefaultFuelConsumption = 3;
        public RaceMotorcycle(double fuel, int horsePower) : base(fuel, horsePower)
        {
        }

        public override double FuelConsumption => DefaultFuelConsumption;

        public override void Drive(double distance)
        {
            if (Fuel > distance * FuelConsumption)
            {
                Fuel -= distance * FuelConsumption;
            }
        }
    }
}
