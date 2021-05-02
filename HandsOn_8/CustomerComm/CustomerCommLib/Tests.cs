using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerCommLib
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void TestCase_SMTPService()
        {
           
            var smtpClient = new Mock<IMailSender>();
            smtpClient.Setup(x => x.SendMail("abc@gmail.com", "Welcome User!!")).Returns(true);
            CustomerComm.CustomerComc component = new CustomerComm.CustomerComc(smtpClient.Object);
            Assert.AreEqual(true, component.SendMailToCustomer());
        }
    }
}
