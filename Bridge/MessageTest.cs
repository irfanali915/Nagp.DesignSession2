using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagp.DesignSession2.Bridge
{
    class MessageTest
    {
        public static void TestSend()
        {
            var textMessage = new TextMessage(new EmailMessageSender())
            {
                From = "test@nagarro.com",
                To = "test1@nagarro.com",
                MessageText = "Schedule demo on 2nd Jan 2022"
            };
            textMessage.Send();

            var emailMessage = new EmailMessage(new TextMessageSender())
            {
                From = "test@nagarro.com",
                To = "test1@nagarro.com",
                Cc = "test1cc@nagarro.com",
                Bcc = "test1bcc@nagarro.com",
                MessageSubject = "Demo schedule",
                MessageText = "Schedule demo on 2nd Jan 2022"
            };
            emailMessage.Send();
        }
    }
}
