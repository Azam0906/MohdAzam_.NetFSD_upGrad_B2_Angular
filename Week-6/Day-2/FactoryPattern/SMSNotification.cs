using System;

namespace oopsDesignDemo.FactoryPattern
{
    internal class SMSNotification:INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS Sent: " + message);
        }
    }
}
