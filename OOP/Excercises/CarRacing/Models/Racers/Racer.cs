using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    public abstract class Racer : IRacer
    {
		private string username;

		private string racingBehavior;

		private int drivingExperience;

		private ICar car;

        protected Racer(string username, string racingBehaviour, int drivingExperiance, ICar car)
        {
            this.Username = username;
            this.RacingBehavior = racingBehaviour;
            this.DrivingExperience = drivingExperiance;
            this.Car = car;
        }

        public ICar Car
		{
			get { return car; }
			private set 
			{
				if (value == null)
				{
                    throw new ArgumentException(ExceptionMessages.InvalidRacerCar);
                }
				car = value; 
			}
		}

		public int DrivingExperience
        {
			get { return drivingExperience; }
			protected set 
			{
				if (value < 0 || value > 100)
				{
                    throw new ArgumentException(ExceptionMessages.InvalidRacerDrivingExperience);
                }
                drivingExperience = value; 
			}
		}


		public string RacingBehavior
        {
			get { return racingBehavior; }
			private set 
			{
				if (string.IsNullOrWhiteSpace(value))
				{
                    throw new ArgumentException(ExceptionMessages.InvalidRacerBehavior);
                }
                racingBehavior = value; 
			}
		}


		public string Username
		{
			get { return username; }
			private set 
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException(ExceptionMessages.InvalidRacerName);
				}
				username = value; 
			}
		}

		public virtual void Race()
		{
			car.Drive();
		}

		public bool IsAvailable()
		{
			if (car.FuelAvailable >= car.FuelConsumptionPerRace)
			{
				return true;
			}

			return false;
		}

        public override string ToString()
        {
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"{this.GetType().Name}: {this.username}");
			sb.AppendLine($"--Driving behavior: {racingBehavior}");
			sb.AppendLine($"--Driving experience: {drivingExperience}");
			sb.AppendLine($"--Car: {car.Make} {car.Model} ({car.VIN})");

			return sb.ToString().TrimEnd();
        }

    }
}
