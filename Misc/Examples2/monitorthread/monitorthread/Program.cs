using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace monitordemo
{
    class TickTock
    {
        public void tick(bool running)
        {
            lock (this)
            {
                if (!running)
                {
                    Monitor.Pulse(this);
                    return;
                }
                Console.Write("Tick  ");
                Monitor.Pulse(this);
                Monitor.Wait(this);
            }
        }
        public void tock(bool running)
        {
            lock (this)
            {
                if (!running)
                {
                    Monitor.Pulse(this);
                    return;
                }
                Console.WriteLine("Tock");
                Monitor.Pulse(this);
                Monitor.Wait(this);
            }
        }
    }
    class MyThread
    {
        public Thread thrd;
        TickTock ttob;
        public MyThread(string name, TickTock tt)
        {
            thrd = new Thread(this.run);
            ttob = tt;
            thrd.Name = name;
            thrd.Start();
        }
        public void run()
        {
            if (thrd.Name == "tick")
            {
                for (int i = 0; i < 5; i++)
                    ttob.tick(true);
                ttob.tick(false);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    ttob.tock(true);
                    ttob.tock(false);
                }
            }
        }
    }
    class TickingClock
    {
        static void Main(string[] args)
        {
            TickTock tt = new TickTock();
            MyThread mt1 = new MyThread("tick", tt);
            MyThread mt2 = new MyThread("tock", tt);

            mt1.thrd.Join();
            mt2.thrd.Join();

            Console.ReadKey();

        }
    }
}
