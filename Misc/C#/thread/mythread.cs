using System;
using System.Threading;
class mythread
{
	public int count;
	public Thread thrd;
	public mythread(string name)
	{
		count=0;
		thrd=new Thread(this.run);
		thrd.Name=name;
		thrd.Start();
	}
	void run()
	{
		Console.WriteLine(thrd.Name+" Starting");
		do
		{
			Thread.Sleep(3000);
			Console.WriteLine("In "+thrd.Name+", count is"+count);
			count++;
		}
		while(count< 10);
		Console.WriteLine(thrd.Name +" is Terminating");
	}
}
class demo
{
	public static void Main()
	{
		mythread mt1=new mythread("child 1");
		mythread mt2=new mythread("child 2");
		mythread mt3=new mythread("child 3");

		Console.WriteLine("Main thread Starting");
		do
		{
			Console.Write(".");
			//Console.WriteLine();
			Thread.Sleep(100);
		}
		while (mt1.thrd.IsAlive && mt2.thrd.IsAlive && mt3.thrd.IsAlive);
		Console.WriteLine("Main Thread Ending");
	}
}
		