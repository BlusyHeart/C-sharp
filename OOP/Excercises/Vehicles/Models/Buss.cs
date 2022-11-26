using MotorVehicles.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models;

namespace MotorVehicles.Models
{
    public class Buss : Vehicle
    {
        const double FuelConsumptionPerKmWithAirConditionOn = 1.4;

        public Buss(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override string Drive(double distance, bool isAirConditionOn)
        {
            if (isAirConditionOn)
            {
                if (FuelQuantity >= distance * (FuelConsumption + FuelConsumptionPerKmWithAirConditionOn))
                {
                    FuelQuantity -= distance * (FuelConsumption + FuelConsumptionPerKmWithAirConditionOn);
                    return $"{this.GetType().Name} travelled {distance} km";
                }
                return $"{this.GetType().Name} needs refueling";

            }
            else
            {
                return base.Drive(distance);
            }

        }

    }
}
