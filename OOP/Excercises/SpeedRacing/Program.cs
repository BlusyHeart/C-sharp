using System;
using System.Linq;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            HashSet<Car> cars = new HashSet<Car>();

            AddCar(numberOfCars, cars);
            Move(cars);
            Print(cars);
        }

        private static void Print(HashSet<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }

        private static void Move(HashSet<Car> cars)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                if (input[0] == "Drive")
                {
                    string model = input[1];
                    double distance = double.Parse(input[2]);
                    
                    foreach (Car car in cars)
                    {
                        if (car.Model == model)
                        {
                            car.Drive(distance);
                            break;
                        }
                    }

                }
            }
        }

        private static void AddCar(int numberOfCars, HashSet<Car> cars)
        {
            for (int i = 0; i < numberOfCars; i++)
            {
                Car car = new Car();
                string[] carDetails = Console.ReadLine().Split();
                string carModel = carDetails[0];
                double fuelAmount = double.Parse(carDetails[1]);
                double fuelConsumption = double.Parse(carDetails[2]);

                car.Model = carModel;
                car.FuelAmount = fuelAmount;
                car.FuelConsumptionPerKilometer = fuelConsumption;
                cars.Add(car);
            }
        }
    }
}



