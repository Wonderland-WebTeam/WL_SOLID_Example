namespace SOLID_Example.DIP.After
{
    public class Notification
    {
        private readonly IMessage _message;

        public Notification(IMessage message)
        {
            _message = message;
        }

        public void Notify()
        {
            _message.SendMessage();
        }
    }
}