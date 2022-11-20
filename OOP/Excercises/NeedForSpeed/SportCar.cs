using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    internal class SportCar : Car
    {
        public SportCar(double fuel, int horsePower) : base(fuel, horsePower)
        {

        }

        public override double FuelConsumption { get; set; } = 10;

        public override void Drive(double distance)
        {
            if (Fuel > distance * FuelConsumption)
            {
                Fuel -= distance * FuelConsumption;
            }
        }
    }
}
