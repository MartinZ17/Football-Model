using System;
using System.Collections.Generic;
using System.Text;

namespace Football_HW
{
    public class Team 
    {
        public string TeamName { get; set; }
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; } = new List<FootballPlayer>();

        public double AverageAgeOfTheTeam(List<FootballPlayer> players)
        {
            double sum = 0;
            foreach (var player in players)
            {
                sum += player.Age;
            }
            return sum / players.Count;
        }
    }
}
