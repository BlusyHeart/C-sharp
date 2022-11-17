using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {       
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; } = 0;

        public void Drive(double distance)
        {
            bool isEnough = FuelAmount >= FuelConsumptionPerKilometer * distance;
            if (isEnough)
            {
                TravelledDistance += distance;
                FuelAmount -= distance * FuelConsumptionPerKilometer;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
