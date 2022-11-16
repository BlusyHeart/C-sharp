using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year): this ()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelConsumption, double fuelQuantity, Engine engine, Tire[] tire) : this(make, model, year, fuelConsumption, fuelQuantity)
        {
            Engine = engine;
            Tire = tire;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelConsumption { get; set; }

        public double FuelQuantity { get; set; }

        public Engine Engine { get; set; }

        public Tire[] Tire { get; set; }

        public void Drive(double distance)
        {
            bool isBiggerThenZero = FuelQuantity - (distance * FuelConsumption) >= 0;
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
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuelQuantity: {FuelQuantity}\nFuelConsumption:{FuelConsumption}";
        }
    }
}
