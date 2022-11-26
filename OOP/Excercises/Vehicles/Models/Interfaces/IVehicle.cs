using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorVehicles.Models.Interfaces
{
    public interface IVehicle
    {
        double FuelQuantity { get; }

        double FuelConsumption { get; }

        public double TankCapacity { get; }

        string Drive(double distance);

        void Refuel(double fuel);
    }
}
