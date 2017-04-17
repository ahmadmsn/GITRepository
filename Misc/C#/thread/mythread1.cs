using System;
using System.Threading;
class mythread1
{
	public int count;
	string thrdname;
	public mythread1(string name)
	{
		count=0;
		thrdname=name;
	}
	public void access()
	{
		Console.WriteLine(thrdname+" Starting");
		do
		{
			Thread.Sleep(500);
			Console.WriteLine("In "+  thrdname+ ", count is "+count);
			count++;
		}
		while(count<10);
		Console.WriteLine(thrdname+" terminating");
	}
}
class demo
{
	public static void Main()
	{
		Console.WriteLine("Main thread started");
		mythread1 mt1=new mythread1("Child1");
		
		//ThreadStart ts=new ThreadStart(mt1.access);
		Thread t=new Thread(mt1.access);
		t.Start();
		do
		{
			Console.Write(".");
			Thread.Sleep(100);
		}
		while(mt1.count<10);
		Console.WriteLine("Main Thread Ending");
	}
}
