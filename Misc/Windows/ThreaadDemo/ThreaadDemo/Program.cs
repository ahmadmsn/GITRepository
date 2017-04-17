using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreaadDemo
{
    class Program
    {       
        static void SimpleWork()
        {
            Console.WriteLine("Thread {0}", Thread.CurrentThread.ManagedThreadId);
        }
        static void Main(string[] args)
        {
            //for (int nCount = 0; nCount <= 5; ++nCount)
            //{
            //    ThreadStart operation = new ThreadStart(SimpleWork);
            //    Thread theThread = new Thread(operation);
            //    theThread.Start();
            //    Thread.Sleep(1000);
            //    //Console.ReadKey();
            //}

            //================================

            //ThreadStart operation = new ThreadStart(SimpleWork);
            //Thread [] theThread = new Thread[5];
            //for (int ncount = 0; ncount < 5; ++ncount)
            //{
            //    theThread[ncount] = new Thread(operation);
            //    theThread[ncount].Start();

            //}
            //foreach (Thread t in theThread)
            //{
            //    t.Join();
            //}
            //Console.ReadKey();

            //====================================

            ParameterizedThreadStart operation = new ParameterizedThreadStart(WorkWithParamater);
            Thread theThread = new Thread(operation);
            theThread.Start("Hello");
            Thread newThread = new Thread(operation);
            newThread.Start("GoodBye");
            Console.ReadKey();
        }
        static void WorkWithParamater(object o)
        {
            string info = (string)o;
            for (int nCount = 0; nCount < 10; ++nCount)
            {
                Console.WriteLine("{0},{1}", info, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(500);
            }
        }

    }
}
