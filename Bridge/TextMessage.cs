using System;

namespace Nagp.DesignSession2.Bridge
{
    public class TextMessage : Message
    {
        public TextMessage(IMessageSender messageSender) : base(messageSender)
        {

        }

        public override void Send()
        {
            _messageSender.SendMessage(this);
        }
    }
}
