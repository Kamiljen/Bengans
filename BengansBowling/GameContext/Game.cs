using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowling.GameContext
{
    public class Game
    {
        public Game()
        {
            Participants = new GameUser[2];
        }
        public int GameId { get; set; }
        public GameUser[] Participants { get; set; }
        public int Player1Score { get; set; } 
        public int Player2Score { get; set; }
        public GameUser Winner { get; set; }
    }
}
