using BengansBowling.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowling.FortKnox
{
    public class FortKnoxBilling
    {
        static List<User> billedUsers;
        public FortKnoxBilling()
        {
            billedUsers = new List<User>();
        }

        public void BillUser(User user)
        {
           billedUsers.Add(user);
        }

        public bool UserBilled(User user)
        {
            return billedUsers.Any(x=>x.Name == user.Name);
        }
    }
}
