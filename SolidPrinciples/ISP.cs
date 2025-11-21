using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SolidPrinciples
{
    public interface IWorker
    {
        void Work();
        void Eat();
    }
    public interface IManager
    {
        void ManagesTeam();
    }
    public class Worker : IWorker
    {
        public void Work()
        {
            WriteLine("Worker is working...");
        }
        public void Eat()
        {
            WriteLine("Worker is Eating..");
        }
    }
    public class Manager : IWorker, IManager
    {
        public void Work()
        {
            WriteLine("Manager is working..");
        }
        public void Eat()
        {
            WriteLine("Manager is eating..");
        }
        public void ManagesTeam()
        {
            WriteLine("Manager is managing the team..");
        }
    }
    internal class ISP
    {
        public static void Main(string[] args)
        {
            IWorker worker = new Worker();
            worker.Work();
            worker.Eat();

            Console.WriteLine();

            Manager manager = new Manager();
            manager.Work();
            manager.Eat();
            manager.ManagesTeam();

            ReadLine();
        }
    }
}
