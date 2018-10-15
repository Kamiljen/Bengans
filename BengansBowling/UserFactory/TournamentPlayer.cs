using BengansBowling.GameContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowling.UserFactory
{
    public class TournamentPlayer : User
    {
        
        public List<Game> Games { get; set; }   


        public override double GetWinRatio()
        {
            int gamesWon = GamesPlayed.Where(x => x.Winner.Name == Name).Count();
            foreach (var game in GamesPlayed)
            {

                WinRatio += Math.Round((Double)GamesPlayed.Count / gamesWon);
            }
            return WinRatio;
        }
    }
}
