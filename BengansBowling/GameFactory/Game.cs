using BengansBowling.UserFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowling.GameFactory
{
    public abstract class Game
    {
        public string Type { get; set; }
        public List<Player> Participants { get; set; }
        public string Winner { get; set; }

        public abstract void SetWinner();   
        
    }
}
    