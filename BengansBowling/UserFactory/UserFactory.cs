
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowling.UserFactory
{
    public class UserFactory
    {
        public User CreateUser(string callerName)
        {
            switch (callerName.ToLower())
            {
                case "tournament":
                    return new TournamentPlayer();
                case "member":
                    return new Member();
                case "player":
                    return new Player();
                default:
                    throw new Exception("Unknown user type");
            }
        }
    }
}
