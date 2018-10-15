using BengansBowling.BookingContext;
using BengansBowling.GameContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowling.LaneMachine
{
    public class Machine
    {
        public List<Game> Games { get; set; }
        public int InitiateMachine(Booking booking)
        {
            var game = new Game { GameId = GetGameId(), Participants = booking.Participants};
            Games.Add(game);
            return game.GameId;
        }
        public void SetGameScore(int player1Score, int player2Score, int gameId)
        {
            var rand = new Random();
            var game = GetGame(gameId);
            var score1 = (player1Score != 0) ? rand.Next(0, 300) : player1Score;
            var score2 = (player2Score != 0) ? rand.Next(0, 300) : player2Score;
            game.Player1Score = score1;
            game.Player2Score = score2;
        }

        public Game GetGameResult(int gameId)
        {
            var game = GetGame(gameId);
            
            return game;
        }

        private int GetGameId()
        {
            int gameId = 1;
            if (Games.Count != 0)
            {
                gameId = Games.Last().GameId;
            }
            return gameId++;
        }

        private Game GetGame(int gameId)
        {
            return Games.SingleOrDefault(x => x.GameId == gameId);
        }
    }
}
