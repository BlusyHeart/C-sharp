using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    internal class Car : Vehicle
    {
        const double summerFuelConsumptionPerKm = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + summerFuelConsumptionPerKm, tankCapacity)
        {
        }
    }
}
