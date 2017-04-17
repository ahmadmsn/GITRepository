using System;
class singdimarray
{
	public static void Main()
	{
		int [] number=new int[10];
		int n=number.Length;
		for(int i=0;i<n;i++)
		{
			number[i]=i+1;
			Console.WriteLine(number[i]);
			
		}
		Console.WriteLine(n);
	}
}