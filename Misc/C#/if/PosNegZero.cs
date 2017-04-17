using System;
class PosNegZero
{
	public static void Main()
	{
		int i;
		for(i=-5;i<=5;i++)
		{
			Console.Write("Testing  "+i+ "Is  :");
		
			if(i<0)
			Console.WriteLine("Negative");
			else if(i==0)
			Console.WriteLine("No Sighn");
			else
			Console.WriteLine("Positive");
		}
	}
}