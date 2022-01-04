using System;

namespace Nagp.DesignSession2.Bridge
{
    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("EmailMessageSender: Sending {0}...", message.GetType().Name);
            Console.WriteLine("From - {0}", message.From);
            Console.WriteLine("To - {0}", message.To);
            if (message is EmailMessage emailMessage)
            {
                Console.WriteLine("Cc - {0}", emailMessage.Cc);
                Console.WriteLine("Bcc - {0}", emailMessage.Bcc);
                Console.WriteLine("MessageSubject - {0}", emailMessage.MessageSubject);
            }
            Console.WriteLine("MessageText - {0}\n\n", message.MessageText);
        }
    }
}
