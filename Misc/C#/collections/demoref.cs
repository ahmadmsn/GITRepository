using System;
class demoref
{
	int alpha,beta;
	public demoref(int i, int j)
	{
		alpha=i;
		beta=j;
	}
	public bool sameas(demoref d)
	{
		if((d.alpha==alpha)&(d.beta==beta))
		return true;
		else
		return false;
	}
	public void copy(demoref d)
	{
		alpha=d.alpha;
		beta=d.beta;
	}
	public void show()
	{
		Console.WriteLine("alpha: {0}, beta: {1}", alpha,beta);
	}
}
class demo
{
	public static void Main()
	{
		demoref d1=new demoref(2,3);
		demoref d2=new demoref(4,5);

		Console.Write(" d1 :");
		d1.show();
		Console.Write(" d2 :");
		d2.show();

		if(d1.sameas(d2))
		Console.WriteLine("d1 and d2 is same");
		else
		Console.WriteLine("d1 and d2 is not same");
		Console.WriteLine();

		d1.copy(d2);
		d1.show();
		d2.show();

		

		
	}
}
		