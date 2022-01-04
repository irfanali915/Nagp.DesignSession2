namespace Nagp.DesignSession2.Bridge
{
    public abstract class Message
    {
        protected readonly IMessageSender _messageSender;

        public Message(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public string From { get; set; }

        public string MessageText { get; set; }

        public string To { get; set; }

        abstract public void Send();
    }
}
