using BengansBowling.UserFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowling.LaneMachine
{
    public interface ILaneMachine
    {
        int InitiateGame(Player player1, Player player2);
        GameResult GetGameResult(int laneId);
    }
}
