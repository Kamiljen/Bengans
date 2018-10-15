
using BengansBowling.UserFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BengansBowling.Repositorys
{
    public class UserRepo
    {
        private static List<Member> users;

        public UserRepo()
        {
            users = new List<Member>();
        }

        public void AddUser(Member user)
        {
            users.Add(user);
        }
        public Member GetUser(string userName)
        {
            return users.SingleOrDefault(x=>x.Name == userName);
        }
        public List<Member> GetUsers()
        {
            return users;
        }
    }
}
