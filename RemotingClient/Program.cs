using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace RemotingClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting client...");

            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            IStudentService service = (IStudentService)Activator.GetObject(
                typeof(IStudentService),
                "http://localhost:8080/StudentService"
            );

            Console.WriteLine("\nAll Students:");
            service.ShowAllStudents();

            Console.Write("\nEnter student id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var student = service.GetStudent(id); 


            Console.WriteLine("\nResult:");
            Console.WriteLine(student == null ? "Student not found" : student.ToString());

            Console.ReadLine();
        }
    }
}
