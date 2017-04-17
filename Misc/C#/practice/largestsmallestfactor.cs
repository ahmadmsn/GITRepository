using System;
class smallestfactor
{
	public static void Main()
	{
		int num=50;
		int i;
		int j;
		int smallest=1;
		int largest=1;
		for(i=2; i<=num; i++)
		{
			if ((smallest==1) & (num%i==0))
			smallest=i;
		}
		Console.WriteLine(smallest);
		for(j=num/2; j<=num; j++)
		{
			if((largest==1) & (num%2==0))
			largest=j;
		}
		Console.WriteLine(largest);		
	}
}