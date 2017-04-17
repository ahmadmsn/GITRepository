using System;
class smallestlargestfactor
{
	public static void Main()
	{
		int num=100;
		int i,j;
		for(i=2;i<=num;i++)
		{
			if((num%i)==0)
			break;
		}
		Console.WriteLine(i);
		for(j=num/2;j>=2;j--)
		{
			if((num%j)==0)
			break;
		}
		Console.WriteLine(j);
	}
}
