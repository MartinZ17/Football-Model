using System;
using System.Collections.Generic;
using System.Text;

namespace Football_HW
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee1 { get; set; }
        public List<Referee> AssistantReferees { get; set; }
        public int ResultTeam1 { get; set; }
        public int ResultTeam2 { get; set; }

        public void Goal(int minute, string player)
        {
            foreach (var p in Team1.Players)
            {
                if(player == p.Name)
                {
                    ResultTeam1++;
                }
            }
            foreach (var p in Team2.Players)
            {
                if(player == p.Name)
                {
                    ResultTeam2 += 1;
                }
            }
            Console.WriteLine($"{player} scored a goal in {minute} minute!!!");
        }

        public void GameResult()
        {
            Console.WriteLine($"The result is {ResultTeam1} - {ResultTeam2}");
        }


        public void Winner()
        {
            if(ResultTeam1 > ResultTeam2)
            {
                Console.WriteLine($"{Team1.TeamName} is winner.");
            }
            else if (ResultTeam1 < ResultTeam2)
            {
                Console.WriteLine($"{Team2.TeamName} is winner.");
            }
            else
            {
                Console.WriteLine("Draw.");
            }
        }
    }
}
