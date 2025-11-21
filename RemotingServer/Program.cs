using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace RemotingServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting server...");

            HttpChannel channel = new HttpChannel(8080);
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(StudentService),
                "StudentService",
                WellKnownObjectMode.Singleton
            );

            Console.WriteLine("Server running at http://localhost:8080/StudentService");
            Console.WriteLine("Waiting for clients...");
            Console.ReadLine();
        }
    }
}
