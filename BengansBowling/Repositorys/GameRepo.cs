using BengansBowling.GameContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowling.Repositorys
{
    public class GameRepo
    {
        private static List<Game> games;
        //private static List<Tournament> tournaments;

        public GameRepo()
        {

        }

        public void SaveGame(Game game)
        {
            games.Add(game);
        }

        public List<Game> GetGames()
        {
            return games;
        }
    }
}
