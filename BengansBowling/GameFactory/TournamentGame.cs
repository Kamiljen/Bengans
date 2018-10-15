using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowling.GameFactory
{
    public class TournamentGame : Game
    {
        public TournamentGame(string type)
        {
            Type = type;
        }

        public override void SetWinner()
        {
            Winner = Participants.OrderByDescending(x => x.WinRatio).First().Name;
        }
    }
}
