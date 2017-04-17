using System;
using System.Threading;
class threadlock
{	
	public int sum;	
	public int addnumber(int [] nums)
	{
		lock(this)
		{
			sum=0;
			for(int i=0;i<nums.Length;i++)
			{
				sum+=nums[i];
				Console.WriteLine("Running total for"+Thread.CurrentThread.Name+" is "+sum);
				Thread.Sleep(500);	
			}		
		}	
		return sum;
		
	}
}
class threaddemo
{
	public Thread thrd;
	int [] a;
	int answer;
	static threadlock tl1=new threadlock();
	public threaddemo(string name, int [] nums)
	{
		thrd=new Thread(this.run);
		a=nums;
		thrd.Name=name;
		thrd.Start();
	}
	void run()
	{
		Console.WriteLine( thrd.Name + " Starting");
		answer=tl1.addnumber(a);
		Console.WriteLine("Sum for"+ thrd.Name+" Is "+answer);
		Console.WriteLine(thrd.Name+" Is Terminating");
	}
}
class demo
{
	public static void Main()
	{
		
		//threadlock tl=new threadlock();
		//int [] b=new int [5];
		
		int [] a=new int [] {1,2,3,4,5};

		threaddemo td1=new threaddemo("child 1", a);
		threaddemo td2=new threaddemo("child 2", a);

		td1.thrd.Join();
		td2.thrd.Join();
		/*b=nums;	
		tl.addnumber(b);*/
	}
}
		