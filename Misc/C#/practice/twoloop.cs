using System;
class twoloops
{
	public static void Main(string [] args)
	{
		int num=100;
		int i,j;
		int smallest,largest;
		smallest=largest=1;
		for(i=2,j=num/2;((i<=num/2) & (j<=num));i++,j++)
		{
			if((smallest==1) & (num%i==0))
			smallest=i;
			
			if((largest==1) & (num%j==0))
			largest=j;
		}
		Console.WriteLine(smallest);
		Console.WriteLine(largest);
	}
}
	