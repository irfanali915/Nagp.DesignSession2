using System;

namespace Nagp.DesignSession2.Bridge
{
    public class EmailMessage : Message
    {
        public EmailMessage(IMessageSender messageSender) : base(messageSender)
        {

        }

        public string MessageSubject { get; set; }

        public string Cc { get; set; }

        public string Bcc { get; set; }

        public string Attachment { get; set; }

        public override void Send()
        {
            _messageSender.SendMessage(this);
        }
    }
}
