using StreeRacing.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StreeRacing
{
    class StartUp
    {
        static void Main()
        {

            Race race = new Race("RockPort Race", "Sprint", 1, 4, 150);

            Car car = new Car("BMW", "320ci", "NFS2005", 150, 1450);

            Console.WriteLine(car);

            race.AddCar(car);
            Console.WriteLine();
            Console.WriteLine(race.RemoveCar("NFS2005"));

            Car carOne = new Car("BMW", "320cd", "NFS2007", 150, 1350);
            Car carTwo = new Car("Audi", "A3", "NFS2004", 131, 1300);

            race.AddCar(carOne);
            race.AddCar(carTwo);
           
            Console.WriteLine(race.GetMostPowerfulCar());
            race.Report();
        }
    }
}
