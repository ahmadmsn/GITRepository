using System;
using System.Threading;
class threaddemo
{
	public int count;
	public Thread thrd;
	public threaddemo(string name)
	{
		count=0;
		thrd=new Thread(this.run);
		thrd.Name=name;
		thrd.Start();
	}
	void run()
	{
		Console.WriteLine(thrd.Name + "Starting");
		do
		{
			Thread.Sleep(500);
			Console.WriteLine("In "+thrd.Name+" Starting" + " Count Is" + count);
			count++;
		}
		while(count<10);
		Console.WriteLine(thrd.Name + " Is Terminating");
	}
}
class demo
{
	public static void Main()
	{
		Console.WriteLine("Main Thread Is Starting");
		threaddemo td=new threaddemo("Child 1");
		threaddemo td2=new threaddemo("Child 2");
		threaddemo td3=new threaddemo("Child 3");
	
		td.thrd.Join();
		Console.WriteLine("Child 1 joined");
		td2.thrd.Join();
		Console.WriteLine("Child 2 joined");
		td3.thrd.Join();
		Console.WriteLine("Child 3 joined");

		Console.WriteLine("Main thred is ending");
	}
}