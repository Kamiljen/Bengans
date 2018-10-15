using BengansBowling.GameContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowling.BookingContext
{
    public class BookingManager
    {
        private List<int> AvailableLanes;
        private List<int> BookedLanes;
        public BookingManager()
        {
            AvailableLanes = new List<int> {1, 2,3,4,5,6,7,8,9,10 };
            BookedLanes = new List<int>();
        }

        public Booking CreateBooking(GameUser[] participants, DateTime from, DateTime to )
        {
            BookedLanes.Add(AvailableLanes.First());
            AvailableLanes.Remove(AvailableLanes.First());
            
            return new Booking { Participants = participants, LaneId = AvailableLanes.First(), From = from, To = to };
        }
    }
}
