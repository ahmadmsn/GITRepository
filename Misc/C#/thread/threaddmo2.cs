using System;
using System.Threading;
class threademo2
{
	public int count;
	public Thread thrd;
	public theraddemo2(string name)
	{
		count=0;
		thrd=new Thread(run);
		thrd.Name=name;
		thrd.Start();
	}
	public void run()
	{
		Console.WriteLine(thrd.Name+" Starting");
		do
		{
			Thread.Sleep(100);
			Console.Write("Amit");
		}
		while(count<10);
		Console.WriteLine(thrd.Name+" Terminating");
	}
}
class demo
{
	public static void Main()
	{
		Console.WriteLine("Main Thread start");
		threademo2 td2=new threademo2("Child1");
		do
		{
			Thread.Sleep(100);
			Console.Write(".");
			
		}
		while(td2.count<10);
		Console.WriteLine("Exiting Main Thread");
	}
}
			
		