
using BengansBowling.UserFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowling.UserContext
{
    public class UserManager
    {
        private readonly AccountFacade _accountFacade;
        public UserManager(AccountFacade accountFacade)
        {
            
            _accountFacade = accountFacade;
        }
        public Member Register(string name, string billingAdress, int id)
        {
            return _accountFacade.RegisterUser(name, billingAdress, id);
            ////change to factorymethod
            //var user = new User {Name = name, BillingAdress = billingAdress };
            // _userRepo.AddUser(user);
            // return user;
        }

        public void SendToBilling(Member user)
        {
            _accountFacade.SendToBilling(user);

        }

        public bool UserBilled(Membership user)
        {
            return _accountFacade.UserBilled(user);
        }


        public Member GetUser(string userName)
        {
            return _accountFacade.GetUser(userName);
        }
        public List<Member> GetUsers()
        {
            return _accountFacade.GetUsers();
        }
    }
}
