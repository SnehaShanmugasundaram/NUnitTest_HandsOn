using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace PlayerManagerLib
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void Test_CreateNewPlayer_EmptyName()
        {
            var mock = new Mock<IPlayerMapper>();

            Player player = Player.RegisterNewPlayer("", mock.Object);
        }

        [TestCase]

        public void Test_CreateNewPlayer_AlreadyExistsInDatabase()
        {
            var mock = new Mock<IPlayerMapper>();
            mock.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(true);

            Player player = Player.RegisterNewPlayer("Test", mock.Object);
        }


        [TestCase]
        public void Test_CreateNewPlayer_DoesNotAlreadyExistInDatabase()
        {
            var mock = new Mock<IPlayerMapper>();
            mock.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);

            Player player = Player.RegisterNewPlayer("Test", mock.Object);

            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(23, player.Age);
            Assert.AreEqual("India", player.Country);
            Assert.AreEqual(30, player.NoOfMatches);
        }
    }
}
