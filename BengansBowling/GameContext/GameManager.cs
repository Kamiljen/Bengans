using System;
using System.Collections.Generic;
using System.Text;
using BengansBowling.BookingContext;
using BengansBowling.LaneMachine;
using BengansBowling.UserFactory;

namespace BengansBowling.GameContext
{
  
    public class GameManager
    {
        private readonly ILaneMachine _laneMachine;
        public GameManager(ILaneMachine laneMachine)
        {
            _laneMachine = laneMachine;
        }

        public int StartGame(List<Player> contestants)
        {
            return _laneMachine.InitiateGame(contestants[0], contestants[1]);
        }
    }
}
