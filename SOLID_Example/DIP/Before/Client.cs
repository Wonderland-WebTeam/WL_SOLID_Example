namespace SOLID_Example.DIP.Before
{
    public class Client
    {
        public void Execute()
        {
            Notification notify = new Notification();

            notify.PromotionalNotification();
        }
    }
}