using System;
using System.Threading;
class threadjoin
{
	public int count;
	public Thread thrd;
	public threadjoin(string name)
	{
		count=0;
		thrd=new Thread(run);
		thrd.Name=name;
		thrd.Start();
	}
	void run()
	lock(this)
	{
		{
			Console.WriteLine("Enter In Child Thread");
			do
			{
				Thread.Sleep(500);
				Console.WriteLine(thrd.Name+" Starting");
				count++;
			}
			while(count<10);
			Console.WriteLine("Exiting Child Thread");
		}
	}
}
class demo
{
	public static void Main()
	{
		Console.WriteLine("Enter Main Thread");
		threadjoin tj=new threadjoin("child1");
		threadjoin tj2=new threadjoin("child2");

		tj.thrd.Join();
		Console.WriteLine("Child 1 is joined");
		tj2.thrd.Join();
		Console.WriteLine("Child 2 is joined");	

		/*do
		{
			Thread.Sleep(100);
			Console.Write(".");
		}
		while(tj.thrd.IsAlive);*/
		Console.WriteLine("Main thread terminate");
	}
}
				
