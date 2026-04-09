using System;

namespace oopsDesignDemo.FactoryPattern
{
    internal class EmailNotification:INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Email Sent: " + message);
        }
    }
}
