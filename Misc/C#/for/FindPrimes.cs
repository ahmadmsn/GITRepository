using System;
class FindPrimes
{
	public static void Main()
	{
		int num;
		int i;
		int factor;
		bool IsPrime;
	
		for(num=2;num<20;num++)
		{
			IsPrime=true;
			factor=0;
			
			for(i=2;i<=num/2;i++)
			{
				if((num%i)==0)
				IsPrime=false;
				factor=i;
			}
			if (IsPrime)
			Console.WriteLine(num +"Is Prime Number");
			else
			Console.WriteLine("Largest Factor Of "+num+ "Is" +factor);			
		}
		
	}
}
