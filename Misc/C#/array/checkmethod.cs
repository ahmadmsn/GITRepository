using System;
class checkmethod
{
	public static void Main()
	{
		int [] x=new int[10];
		for(int i=0;i<10;i++)
		{
			
			x[i]=i+1;
			Array.Clear(x);
			Console.WriteLine(x[i]);
		}
	}
}