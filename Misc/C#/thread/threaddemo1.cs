using System;
using System.Threading;
class threaddemo1
{
	public int count;
	public Thread thrd;
	public threaddemo1(string name)
	{
		count=0;
		thrd=new Thread(run);
		thrd.Name=name;
		thrd.Start();
	}
	public void run()
	{
		Console.WriteLine(thrd.Name+ " Starting");
		do
		{
			Thread.Sleep(500);
			Console.WriteLine("In " + thrd.Name+ ", count is "+count);
			count++;
		}
		while(count<10);
		Console.WriteLine(thrd.Name+" Terminating");
	}
}
class demo
{
	public static void Main()
	{
		threaddemo1  td=new threaddemo1("Child1");
		do
		{
			Thread.Sleep(100);
			Console.Write(".");
			
		}
		while(td.count<10);
		Console.WriteLine("Main Thread Ending");
		
	}
}
		
