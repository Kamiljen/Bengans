
using BengansBowling.UserFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowling.FortKnox
{
    public class FortKnoxBilling
    {
        static List<Member> billedUsers;
        public FortKnoxBilling()
        {
            billedUsers = new List<Member>();
        }

        public void BillUser(Member user)
        {
           billedUsers.Add(user);
        }

        public bool UserBilled(Member user)
        {
            return billedUsers.Any(x=>x.Name == user.Name);
        }
    }
}
