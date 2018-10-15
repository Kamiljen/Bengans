using BengansBowling.FortKnox;
using BengansBowling.Repositorys;
using BengansBowling.UserContext;
using BengansBowling.UserFactory;
using Moq;
using System;
using Xunit;

namespace TestCases
{
    public class UnitTest1
    {
        
        [Fact]
        public void RegisterNewUser()
        {

           
            var userManager = GetUserManager();
            var membership = userManager.Register(name: "Alex", billingAdress:  "Gotlandsgatan 2", id: 1);
            userManager.SendToBilling(membership);
            var expected = 1;
            var actual = userManager.GetUser("Alex").Id;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void PlayeGame()
        {
            var _userStore = new Mock<UserRepo>();
            
            

            var userManager = GetUserManager();
            var membership = userManager.Register(name: "Alex", billingAdress: "Gotlandsgatan 2", id: 1);
            userManager.SendToBilling(membership);
            var expected = 1;
            var actual = userManager.GetUser("Alex").Id;

            Assert.Equal(expected, actual);

        }

        private static UserManager GetUserManager()
        {
            var fortknox = new FortKnoxBilling();
            var userRepo = new UserRepo();
            var accountFacade = new AccountFacade(fortknox, userRepo);
            var userManager = new UserManager(accountFacade);
            return userManager;
        }
    }
}
