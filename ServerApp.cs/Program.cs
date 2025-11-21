using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
using RemotingLib;
using RemotingTrn;

namespace ServerApp
{
    // Connect to remote object


    public class ServerClass
    {
        // make the class library public (host the library file)


        public static void Main()
        {
            TcpChannel channel = new TcpChannel(8085);// i am using tcp protocol

            //Channel means path or route=route is type of TCP route= create a seperate route
            ChannelServices.RegisterChannel(channel, false);

            //which object (service) client acess remotely
            RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(ServiceClass),//which class u want to register(make the class public)
                    "Hi",//unique name to be used when client connect to server
                     WellKnownObjectMode.Singleton);//singleton means create single object for the client
                                         //server creates object for each client

            Console.WriteLine("Server started... Listening on port 8085");
            Console.WriteLine("Press ENTER to stop the server");
            Console.Read();
        }
    }
}

