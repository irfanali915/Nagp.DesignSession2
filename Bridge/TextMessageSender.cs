using System;

namespace Nagp.DesignSession2.Bridge
{
    public class TextMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("TextMessageSender: Sending {0}...", message.GetType().Name);
            Console.WriteLine("From - {0}", message.From);
            Console.WriteLine("To - {0}", message.To);
            Console.WriteLine("MessageText - {0}\n\n", message.MessageText);


            if (message is EmailMessage emailMessage)
            {
                //Forward in case of email message
                Console.WriteLine("Cc - {0}", emailMessage.Cc);
                message = new TextMessage(this)
                {
                    To = emailMessage.Cc,
                    MessageText = $"{message.MessageText} - It is Cc message"
                };
                message.Send();

                message = new TextMessage(this)
                {
                    To = emailMessage.Bcc,
                    MessageText = $"{message.MessageText} - It is Bcc message"
                };
                message.Send();
            }
        }
    }
}
