using System;
using System.Threading;
class threaddemo2
{
	public int count;
	public Thread thrd;
	public threaddemo2(string name)
	{
		count=0;
		thrd=new Thread(run);
		thrd.Name=name;
		thrd.Start();
	}
	public void run()
	{
		Console.WriteLine("Child thread is Starting");
		do
		{
			Thread.Sleep(500);
			Console.Write("AMIT");
			//Console.WriteLine();
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
		Console.WriteLine("Main Thread start");
		threaddemo2 td2=new threaddemo2("child 1");
		do
		{
			Thread.Sleep(400);
			Console.Write("\nAdmiral"+ " ");
			
		}

		while(td2.count<10);
		Console.WriteLine();
		Console.WriteLine("Exiting Main Thread");
	}
}
			
		