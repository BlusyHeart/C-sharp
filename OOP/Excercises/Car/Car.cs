using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelConsumption { get; set; }

        public double FuelQuantity { get; set; }

        public void Drive(double distance)
        {
            bool isBiggerThenZero = FuelQuantity - (distance * FuelConsumption) > 0;
            if (isBiggerThenZero)
            {
                FuelQuantity -= (distance * FuelConsumption);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity}";
        }
    }
}
