using System;
class findprime
{
	public static void Main()
	{
		int num;
		int i;
		int factor;
		bool isprime;
		for(num=2; num<20; num++)
		{
			isprime=true;
			factor=0;
			for(i=2; i<=num/2; i++)
			{
				if((num % i) == 0)
				break;
				{
					isprime=false;
					factor=i;
				}
			}
			if(isprime)
			Console.WriteLine(num+"Is Prime");
			//else
			//Console.WriteLine("Largest Factor Of"+num+"is"+factor);
		}
	}
}
	