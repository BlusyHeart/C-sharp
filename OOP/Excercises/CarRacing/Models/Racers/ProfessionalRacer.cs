using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    public class ProfessionalRacer : Racer
    {
        private const int DRIVING_EXPERIENCE = 30;
        private const string RACING_BEHAVIOR = "strict";
        private const int EXPERIANCE_INCREMENTOR = 10;

        public ProfessionalRacer(string username, ICar car) : base(username, RACING_BEHAVIOR, DRIVING_EXPERIENCE, car)
        {
        }

        public override void Race()
        {
            base.Race();
            DrivingExperience += EXPERIANCE_INCREMENTOR;
        }
    }
}
