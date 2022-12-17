using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        private const double BEHAVIOR_STRICT_MULTIPLAYER = 1.2;
        private const double BEHAVIOR_AGGRESSIVE_MULTIPLAYER = 1.1;

        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
           
            if (!racerOne.IsAvailable())
            {
                return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }
            else if (!racerTwo.IsAvailable()) 
            {
                return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }
            else if (!racerOne.IsAvailable() && !racerTwo.IsAvailable())
            {
                return "Race cannot be completed because both racers are not available!";
            }
            else
            {
                racerOne.Race();
                racerTwo.Race();

                double chanceOfWinningFirstRacer = 0;
                double chanceOfWinningSecondRacer = 0;

                if (racerOne.RacingBehavior == "strict")
                {
                    chanceOfWinningFirstRacer = racerOne.Car.HorsePower * racerOne.DrivingExperience * BEHAVIOR_STRICT_MULTIPLAYER;
                }
                else
                {
                    chanceOfWinningFirstRacer = racerOne.Car.HorsePower * racerOne.DrivingExperience * BEHAVIOR_AGGRESSIVE_MULTIPLAYER;
                }

                if (racerTwo.RacingBehavior == "strict")
                {
                    chanceOfWinningSecondRacer = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * BEHAVIOR_STRICT_MULTIPLAYER;
                }
                else
                {
                    chanceOfWinningSecondRacer = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * BEHAVIOR_AGGRESSIVE_MULTIPLAYER;
                }

                if (chanceOfWinningFirstRacer > chanceOfWinningSecondRacer)
                {
                    return $"{racerOne.Username} has just raced against {racerTwo.Username}! {racerOne.Username} is the winner!";
                }
                else
                {
                    return $"{racerOne.Username} has just raced against {racerTwo.Username}! {racerTwo.Username} is the winner!";
                }
               
            }
        }
    }
}
