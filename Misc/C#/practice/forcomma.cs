using System;
class forcomma
{
	public static void Main(string [] args)
	{
		int i,j;
		int smallest,largest;
		int num;
		num=100;

		largest=smallest=1;
		for(i=2, j=num/2;(i<=num/2) & (j>=2);i++,j++)
		{
			if((smallest == 1) & ((num %i )==0))
			smallest=i;
			
			if((largest==1) & ((num%j) ==0))
			largest=j;
		}
		Console.WriteLine("Largest Factor"+largest);
		 Console.WriteLine("Lowest Factor"+smallest);
	}
}