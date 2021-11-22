using System;

namespace SOLID_Example.DIP.After
{
    public class Line : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("Send Line Message");
        }
    }
}