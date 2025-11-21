using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment1
{
    public sealed class Logger
    {
        private static Logger instance = null;
        private static readonly object lockObject = new object();
        private Logger() { }
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Logger();
                        }
                    }
                }
                return instance;
            }
        }
        public void WriteLog(string message)
        {
            string path = "log.txt";
            string logMessage = $"{DateTime.Now}: {message}";
            File.AppendAllText(path, logMessage + Environment.NewLine);

            Console.WriteLine("Log written: " + message);
        }
    }
}
