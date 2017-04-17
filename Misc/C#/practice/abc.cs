using System;
class abc1
{
	
	public static void Main()
	{
		 int i,j;
		bool isprime;
		int factor;
		for (i=2;i<=10;i++)
		{
			isprime=true;
			factor=0;
			for(j=2;j<=i/2;j++)
			{
				if((i%j)==0)
				isprime=false;		
				factor=j;
			}
		if (isprime)
		Console.WriteLine(i);	
		else
		Console.WriteLine("largest factor of" +i+"is"+factor);
		}
		
	}
}	