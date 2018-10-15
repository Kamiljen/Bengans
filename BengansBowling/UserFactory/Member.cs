using BengansBowling.GameContext;
using BengansBowling.UserContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowling.UserFactory
{
    public class Member : User
    {
        public Member()
        {
            GamesPlayed = new List<Game>();
            Memberships = new List<Membership>();
        }
        public string BillingAdress { get; set; }
        

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
