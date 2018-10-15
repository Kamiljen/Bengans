using BengansBowling.GameContext;
using BengansBowling.UserContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowling.UserFactory
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Game> GamesPlayed { get; set; }
        public double WinRatio { get; set; }
        public int Score { get; set; }

        public List<Membership> Memberships { get; set; }

        public abstract double GetWinRatio();
    }
}
