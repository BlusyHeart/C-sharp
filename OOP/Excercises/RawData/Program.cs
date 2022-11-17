using System;
using System.Linq;
using System.Collections.Generic;

namespace RawData
{
    public class StartUp
    {
        public static void Main()
        {

            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            
            CreateListOfCars(numberOfCars, cars);
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<Car> fragileCargoCars = cars.Where(car => car.Cargo.Type == "fragile" 
                && car.Tires.Any(tire => tire.Pressure < 1))
                .ToList();
                PrintFlamableCarModel(fragileCargoCars);
            }
            else
            {

                List<Car> flamableCargoCars = cars.Where(car => car.Cargo.Type == "flammable" 
                && car.Engine.Power > 250).ToList();
                PrintFragileCarModel(flamableCargoCars);
            }

        }

        private static void PrintFlamableCarModel(List<Car> flamableCargoCars)
        {
            foreach (Car car in flamableCargoCars)
            {
                Console.WriteLine(car.Model);
            }
        }

        private static void PrintFragileCarModel(List<Car> fragileCargoCars)
        {
            foreach (Car car in fragileCargoCars)
            {
                Console.WriteLine(car.Model);
            }
        }

        private static void CreateListOfCars(int numberOfCars, List<Car> cars, List<Tire> tires)
        {
            for (int i = 0; i < numberOfCars; i++)
            {

                string[] carData = Console.ReadLine().Split();               
                Car car = CreateCar(carData);
                cars.Add(car);
            }
        }

        private static Car CreateCar(string[] carData)
        {
            List<Tire> tires = new List<Tire>();
            AddTire(tires, carData);        
            string carModel = carData[0];
            int engineSpeed = int.Parse(carData[1]);
            int enginePower = int.Parse(carData[2]);
            int cargoWeight = int.Parse(carData[3]);
            string cargoType = carData[4];

            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoType, cargoWeight);

            Car car = new Car(carModel, engine, cargo, tires);
            return car;
        }

        private static void AddTire(List<Tire> tires, string[] carData)
        {
            for (int index = 5; index < carData.Length; index += 2)
            {
                double pressure = double.Parse(carData[index]);
                int age = int.Parse(carData[index + 1]);
                Tire tire = new Tire(age, pressure);
                tires.Add(tire);
            }
        }
    }
}



