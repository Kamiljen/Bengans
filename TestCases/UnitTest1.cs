using BengansBowling.FortKnox;
using BengansBowling.GameContext;
using BengansBowling.LaneMachine;
using BengansBowling.Repositorys;
using BengansBowling.UserContext;
using BengansBowling.UserFactory;
using Moq;
using System;
using System.Linq;
using Xunit;

namespace TestCases
{
    public class UnitTest1
    {
        
        [Fact]
        public void RegisterNewUser()
        {

           
            var userManager = GetUserManager();
            var userOne = userManager.Register(name: "Alex", billingAdress:  "Gotlandsgatan 2", id: 1);
            var userTwo = userManager.Register(name: "Gustav", billingAdress: "Gotlandsgatan 3", id: 2);
            userManager.SendToBilling(userOne);
            userManager.SendToBilling(userTwo);
            var expected = 2;
            var actual = userManager.GetUsers().Count;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void PlayeGame()
        {
            var userManager = GetUserManager();
            var contestants = userManager.GetUsers().Take(2);

            var laneMachine = new Mock<ILaneMachine>();
            laneMachine.Setup(x => x.GetGameResult(1)).Returns(new GameResult { });
            
            
            
            var expected = "";
            var actual = "";

            Assert.Equal(expected, actual);

        }

        private static UserManager GetUserManager()
        {
            var fortknox = new Mock<IFortKnox>();
            var userRepo = new UserRepo();
            var accountFacade = new AccountFacade(fortknox.Object, userRepo);
            var userManager = new UserManager(accountFacade);
            return userManager;
        }
        private static GameManager GetGameManager(ILaneMachine laneMachine)
        {
           
            var gameManager = new GameManager(laneMachine);
            //var fortknox = new FortKnoxBilling();
            //var userRepo = new UserRepo();
            //var accountFacade = new AccountFacade(fortknox, userRepo);
            //var userManager = new UserManager(accountFacade);
            return gameManager;
        }
    }
}
