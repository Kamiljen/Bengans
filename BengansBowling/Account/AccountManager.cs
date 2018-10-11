using BengansBowling.FortKnox;
using BengansBowling.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowling.Account
{
    public class AccountManager
    {
        private readonly FortKnoxBilling _billing;
        private readonly UserRepo _userRepo;
        public AccountManager(FortKnoxBilling billing, UserRepo userRepo)
        {
            _billing = billing;
            _userRepo = userRepo;
        }
        public User Register(string name, string billingAdress)
        {
           //change to factorymethod
           var user = new User {Name = name, BillingAdress = billingAdress };
            _userRepo.AddUser(user);
            return user;
        }

        public void SendToBilling(User user)
        {
            _billing.BillUser(user);
            user.Billed = true;
        }

        public bool UserBilled(User user)
        {
            return _billing.UserBilled(user);
        }


        public User GetUser(string userName)
        {
            return _userRepo.GetUser(userName);
        }
        public List<User> GetUsers()
        {
            return _userRepo.GetUsers();
        }
    }
}
