using CustomerCommLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerComm
{
   public class CustomerComc
    {
        IMailSender _mailSender;

        public CustomerComc(IMailSender mailSender)
        {
            this._mailSender = mailSender;
        }

        public bool SendMailToCustomer()
        {
            _mailSender.SendMail("abc@gmail.com", "Hello User.. Welcome!");
            return true;
        }
    }
}
