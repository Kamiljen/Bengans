using BengansBowling.UserFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowling.GameFactory
{
    public class NormalGame : Game
    {
        public NormalGame(string type)
        {
            Type = type;
        }  

        public override void SetWinner()
        {
            Winner = Participants.OrderByDescending(x => x.Score).First().Name;
        }
    }
}
