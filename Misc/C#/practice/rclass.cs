using System;
class rclass
{
	public int rfact(int n)
	{
		int result;
		if(n==1) return 1;
		result=rfact(n-1) * n;
		return result;
	}
	public int ifact(int n)	
	{
		int result=1;
		for(int j=1;j<=n;j++)
		{
			result=result*j;
		}
		return result;	
	}
}
class demo 
{
	public static void Main()
	{
		rclass r=new rclass();
		Console.WriteLine("Factorial Of 3 is:"+r.rfact(3));
		Console.WriteLine("Factorial Of 4 is:"+r.ifact(4));
	}	
}

