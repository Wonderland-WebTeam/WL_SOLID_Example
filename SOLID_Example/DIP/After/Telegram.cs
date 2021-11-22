using System;

namespace SOLID_Example.DIP.After
{
    public class Telegram : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Send Telegram Message");
        }
    }
}