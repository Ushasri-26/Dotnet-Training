using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadedLogMethods
{
    class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Message] {message}");
        }
        public void Log(string message, int level)
        {
            Console.WriteLine($"[level {level}] {message}");
        }
        public void Log(string message, DateTime time)
        {
            Console.WriteLine($"[{time}] {message}");
        }
        public void Log(string message, int level, DateTime Time)
        {
            Console.WriteLine($"[{Time}] [Level {level}] {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger log=new Logger();
            log.Log("System started");
            log.Log("Warning occurred", 2);
            log.Log("Backup completed", DateTime.Now);
            log.Log("Critical failure", 5, DateTime.Now);
        }
    }
}
