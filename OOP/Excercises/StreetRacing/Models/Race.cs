using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreeRacing.Models
{
    internal class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            Participants = new List<Car>();
        }


        public List<Car> Participants { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Laps { get; set; }

        public int Capacity { get; set; }

        public int MaxHorsePower { get; set; }

        public void Count() => Participants.Count();

        public void AddCar(Car car)
        {
            if (CheckLicensePlate(car.LicensePlate) && CheckCapacity() && CheckHorsePower(car.HorsePower))
            {
                Participants.Add(car);
            }
        }

        private bool CheckLicensePlate(string licensePlate) =>
            !Participants.Any(x => x.LicensePlate == licensePlate);

        private bool CheckCapacity() => Participants.Count + 1 <= Capacity;

        private bool CheckHorsePower(double horsePower) => horsePower <= MaxHorsePower;

        public bool RemoveCar(string licensePlate)
            => Participants.Remove(Participants.Find(x => x.LicensePlate == licensePlate));

        public Car FindCar(string licensePlate) => Participants.FirstOrDefault(x => x.LicensePlate == licensePlate);

        public Car GetMostPowerfulCar()
            => Participants.OrderByDescending(x => x.HorsePower).FirstOrDefault();

        public void Report()
        {
            Console.WriteLine($"Race: {Name} - Type: {Type} (Laps: {Laps})\n{string.Join(Environment.NewLine, Participants)}");
        }
    }
}
