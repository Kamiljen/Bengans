using BengansBowling.UserFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowling.UserContext
{
    public class Membership
    {
        public Member User { get; set; }
        public bool HasPayedForYear { get; set; }
        public int CurrentYear { get; set; }

    }
}
