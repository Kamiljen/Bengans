using BengansBowling.FortKnox;
using BengansBowling.Repositorys;
using BengansBowling.UserFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowling.UserContext
{
   
    public class AccountFacade
    {

        private readonly FortKnoxBilling _billing;
        private readonly UserRepo _userRepo;

        public AccountFacade(FortKnoxBilling billing, UserRepo userRepo)
        {
            _billing = billing;
            _userRepo = userRepo;
        }

        public Member RegisterUser(string name, string billingAdress, int id)
        {
            var user = new Member { Name = name, BillingAdress = billingAdress, Id = id };
            user.Memberships.Add( new Membership {User = user, HasPayedForYear= false, CurrentYear = DateTime.Now.Year });
            _userRepo.AddUser(user);
            return user;
        }

        public void SendToBilling(Member user)
        {
            _billing.BillUser(user);
            var membership = user.Memberships.OrderByDescending(x => x.CurrentYear).First();
            membership.HasPayedForYear = true;
        }

        public bool UserBilled(Membership user)
        {
            return _billing.UserBilled(user.User);
        }

        public Member GetUser(string userName)
        {
            return _userRepo.GetUser(userName);
        }

        public List<Member> GetUsers()
        {
            return _userRepo.GetUsers();
        }
    }
}
