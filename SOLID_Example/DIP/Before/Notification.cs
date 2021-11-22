namespace SOLID_Example.DIP.Before
{
    public class Notification
    {
        private readonly Message _message;

        public Notification()
        {
            _message = new Message();
        }

        public void PromotionalNotification()
        {
            _message.SendMessage();
        }
    }
}