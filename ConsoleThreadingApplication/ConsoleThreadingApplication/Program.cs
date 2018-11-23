using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//http://www.learncsharptutorial.com/threading-and-types-of-threading-stepbystep.php

namespace ConsoleThreadingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Example : Without threads
            //Thread th = Thread.CurrentThread;
            //Work1();
            //Work2();

            //Second Example : With Threads
            //Thread oThreadone = new Thread(Work1);
            //Thread oThreadtwo = new Thread(Work2);

            //oThreadone.Start();
            //oThreadtwo.Start();

            //Third Example : Join
            //Thread oThread = new Thread(MethodJoin);
            //oThread.Start();
            //oThread.Join();
            //Console.WriteLine("work completed..!");

            //Fourth Example : Sleep
            //Stopwatch stWatch = new Stopwatch();
            //stWatch.Start();

            //Thread oThread = new Thread(ProcessSleep);
            //oThread.Start();
            //oThread.Join();

            //stWatch.Stop();
            //TimeSpan ts = stWatch.Elapsed;

            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            //Console.WriteLine("TotalTime " + elapsedTime);
            //Console.WriteLine("work completed..!");

            //Fifth Example : Foreground Thread
            //Thread oThread = new Thread(WorkThread);
            //oThread.Start();
            //Console.WriteLine("Main Thread Quits..!");
            

            //Sixth Example : Background Thread - Not working as explained on the website
            Thread oThread = new Thread(WorkThread);
            oThread.Start();
            oThread.IsBackground = true;
            Console.WriteLine("Main Thread Quits..!");
            Console.ReadKey();
        }


        static void Work1()
        {
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("Work 1 is called " + i.ToString());

            }

        }

        static void Work2()

        {
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("Work 2 is called " + i.ToString());

            }

        }

        static void MethodJoin()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("work is in progress..!");

            }

        }

        static void ProcessSleep()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("work is in progress..!");
                Thread.Sleep(4000); //Sleep for 4 seconds
            }
        }

        static void WorkThread()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Worker Thread is in progress..!");
                Thread.Sleep(2000); //Sleep for 2 seconds

            }
            Console.WriteLine("Worker Thread Quits..!");
        }
    }
}
