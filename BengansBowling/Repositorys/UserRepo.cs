using BengansBowling.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowling.Repositorys
{
    public class UserRepo
    {
        private static List<User> users;

        public UserRepo()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }
        public User GetUser(string userName)
        {
            return users.SingleOrDefault(x=>x.Name == userName);
        }
        public List<User> GetUsers()
        {
            return users;
        }
    }
}
