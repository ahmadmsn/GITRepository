using System;
class comma
{
	public static void Main()
	{
		int i,j;
		int smallest,largest;
		int num;
		num=100;
		smallest=largest=1;
		for(i=2,j=num/2;(i<=num/2) &(j>=2);i++,j--)
		{
			if((num%i)==0)
			{
				smallest=i;
				break;
			}
			if((num%j)==0)
			{
				largest=j;
				break;
			}
		}
		Console.WriteLine("Smallest Factor of"+num+" Is " +i);
		Console.WriteLine("Largest Factor of" +num+ " Is " +j);
	}
}
		