using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notification Factory
            Console.WriteLine("Enter notification type (email / sms / push):");
            string input = Console.ReadLine();

            INotification notification = NotificationFactory.GetNotification(input);

            Console.WriteLine("Enter your message:");
            string msg = Console.ReadLine();
            notification.send(msg);
            
            //Logger
            Logger logger = Logger.Instance;
            logger.WriteLog("Application started");
            logger.WriteLog("User logged in");
            logger.WriteLog("Error: Something went wrong!");

            //Game Character Prototype
            GameCharacterPrototype warrior1 = CharacterPrototypes.WarriorPrototype.Clone();
            warrior1.Skills.Add("Power Strike");
            GameCharacterPrototype warrior2 = CharacterPrototypes.WarriorPrototype.Clone();
            warrior2.Health = 180;
            warrior1.Skills.Add("Rage Mode");
            Console.WriteLine("Warrior 1:");
            warrior1.Display();

            Console.WriteLine("Warrior 2:");
            warrior2.Display();

            Console.WriteLine("Original Warrior Prototype:");
            CharacterPrototypes.WarriorPrototype.Display();
            Console.ReadLine();



        }
    }
}
