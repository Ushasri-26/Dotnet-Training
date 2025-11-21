using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    internal class TPLDemo
    {
        public void NonParallel()
        {
            //runs slower
            //does not uses library
            // i want to keep track.how much time it took to run the loop

            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();//timer starts
            for (int i = 0; i < 15; i++)
            {
                //by default it uses a single thread to do the job
                //by default it uses as single processor to do the job
                Console.WriteLine("Non Parallel Method is Running" + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
            sw.Stop();//timer ends
            Console.WriteLine("Total Milliseconds took is : " + sw.ElapsedMilliseconds);

        }
        public void Parellel()
        {
            //runs faster
            //uses library
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();//timer starts
            Parallel.For(0, 16, i =>
            {
                Console.WriteLine("Non Parallel Method Running" + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            });
            sw.Stop();//timer stops
            Console.WriteLine("Total milliseconds took is" + sw.ElapsedMilliseconds);
            //1. It uses multiple threads behind the scene
            //2. The loop broken into multiple parts,each part runs simultaneously from different cors
            //3. Each part of the loop is called as task
            //4. Internally it uses task class , to run simultaneously
            //5. Each task have its own thread
            //6. Task always uses ThreadPool
            //7. ThreadPool is pool of threads already running the memory

            //Realtime usage:
            // You have send a mail for 10000 people simultaneously
            // You want to logging to database
            // Send alerts or sms for users/many peoples simultaneously

        }
        public async void TASKDEMO()
        {
            //job-1
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method1 Called");
                    Thread.Sleep(1000);
                }

            });

            // await : is a simplified way to wa

            // job -2
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Method2 Called");
                    Thread.Sleep(1000);
                }
            });

            //Task. WaitAll(t1, t2);//dont continue with next line until t1 and t2 are done with job
            //Task.WaitAny(t1, t2);// continue next line , if any 1 task completed
            Console.WriteLine("Both The task Completed successfully");


        }
    }
}
