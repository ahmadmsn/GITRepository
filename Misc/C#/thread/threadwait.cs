using System;
using System.Threading;
class threadwait
{
	public void tick(bool running)
	{
		lock(this)
		{
			if(!running)
			{
				Monitor.Pulse(this);
				return;
			}
			Console.WriteLine("TICK ");
			Monitor.Pulse(this);
			Monitor.Wait(this);
		}
	}
	public void tock(bool running)
	{
		lock(this)
		{
			if(!running)
			{
				Monitor.Pulse(this);
				return;
			}
			Console.WriteLine("TOCK ");
			Monitor.Pulse(this);
			Monitor.Wait(this);
		}
	}
}
class mythread
{
	public Thread thrd;
	threadwait ttob;
	public mythread(string name, threadwait tt)
	{
		thrd=new Thread(this.run);
		ttob=tt;
		thrd.Name=name;
		thrd.Start();
	}
	void run()
	{
		//Console.WriteLine("Enter Child Thread");
		if(thrd.Name=="tick")
		{
			for(int i=0; i<5;  i++)
			ttob.tick (true);
			ttob.tick (false);
		}
		else
		{
			for(int i=0;i<5;i++)
			ttob.tock (true);
			ttob.tock (false);
		}
	}
}
class demo
{
	public static void Main()
	{
		threadwait tt=new threadwait();
		mythread mt1=new mythread("TICK",tt);
		mythread mt2=new mythread("TOCK",tt);

		mt1.thrd.Join();
		mt2.thrd.Join();
		Console.WriteLine("Clock Stopped");
	}
}
		
	