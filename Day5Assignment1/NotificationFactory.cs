using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day5Assignment1
{
    public interface INotification
    {
        void send(string message);
    }
    public class EmailNotification : INotification
    {
        public void send(string message)
        {
            WriteLine($"Email sent: {message}");
        }
    }
    public class SmsNotification : INotification
    {
        public void send(string message)
        {
            WriteLine($"SMS sent: {message}");
        }
    }
    public class PushNotification : INotification
    {
        public void send(string message)
        {
            WriteLine($"Push Notification sent: {message}");
        }
    }
    public static class NotificationFactory
    {
        public static INotification GetNotification(string type)
        {
            type = type.ToLower();

            if (type == "email")
                return new EmailNotification();

            if (type == "sms")
                return new SmsNotification();

            if (type == "push")
                return new PushNotification();

            throw new Exception("Invalid notification type");
        }
    }
}
