using System;
using System.Collections.Generic;

namespace Football_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FootballPlayer> players1 = new List<FootballPlayer>()
            {
                new Goalkeeper("Thibaut Courtois", 31, 1, 200),
                new Defender("Dani Carvajal", 31, 2, 173),
                new Defender("Eder Militao", 25, 3, 186),
                new Defender("David Alaba", 30, 4, 180),
                new Defender("Antonio Rudiger", 30, 22, 190),
                new Midfield("Luca Modric", 37, 10, 172),
                new Midfield("Toni Kroos", 33, 8, 183),
                new Midfield("Fede Valverde", 24, 15, 182),
                new Striker("Rodrygo", 22, 21, 174),
                new Striker("Vini Jr", 22, 20, 176),
                new Striker("Karim Benzema", 35, 9, 185)
            };
            List<FootballPlayer> players2 = new List<FootballPlayer>()
            {
                new Goalkeeper("ter Stegen", 31, 1, 187), // ok
                new Defender("Ronald Araujo", 24, 4, 188), // smeshnik
                new Defender("Jules Kounde", 24, 23, 180),
                new Defender("Eric Garcia", 22, 24, 182),
                new Defender("Alejandro Balde", 19, 28, 175),
                new Midfield("Pedri", 20, 8, 174), // mnogo bqgash we nqmash izmaraqne
                new Midfield("Gavi", 18, 30, 173), // smeshnik
                new Midfield("Sergio Busquets", 34, 5, 189), //smeshnik
                new Striker("Ferran Torres", 23, 11, 182), //smeshnik
                new Striker("Ansu Fati", 20, 10, 178),
                new Striker("Robert Lewandowski", 34, 9, 185) // mnogo cyka
            };
            Team team1 = new Team()
            {
                TeamName = "Real Madrid",
                Players = players1,
                Coach = new Coach("Carlo Ancelotti", 63),
            };
            Team team2 = new Team()
            {
                TeamName = "Barcelona",
                Players = players2,
                Coach = new Coach("Xavi", 43)
            };
            Referee mainReferee = new Referee("Elon Musk", 43);
            List<Referee> assistantReferees = new List<Referee>()
            {
                new Referee("Vladko Putin", 54),
                new Referee("Mariah Carey", 54)
            };
            Game game1 = new Game()
            {
                Team1 = team1,
                Team2 = team2,
                Referee1 = mainReferee,
                AssistantReferees = assistantReferees
            };
            game1.Goal(43, "Karim Benzema");
            game1.GameResult();
            game1.Goal(45, "Robert Lewandowski");
            game1.GameResult();
            game1.Goal(64, "Karim Benzema");
            game1.GameResult();
            game1.Winner();
        }
    }
}
