using System;

namespace oopsDesignDemo.FactoryPattern
{
    internal class PushNotification:INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Push Notification Sent: " + message);
        }
    }
}
