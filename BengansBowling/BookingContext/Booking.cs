using BengansBowling.GameContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowling.BookingContext
{
   public class Booking
    {
        public Booking()
        {
            Participants = new GameUser[2];
        }
        public int LaneId { get; set; }
        public DateTime To { get; set; }
        public DateTime From { get; set; }
        public GameUser[] Participants { get; set; }

    }
}
