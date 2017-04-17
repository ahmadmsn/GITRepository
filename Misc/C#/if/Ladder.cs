using System;
class Ladder
{
	public static void Main()
	{
		int i;
		for(i=2;i<12;i++)
		{
			if((i%2)==0)
			Console.WriteLine("Smallest Factor Of " + i +" Is 2");
			
			else if((i%3)==0)
			Console.WriteLine("Smallest Factor Of " + i +" Is 3");

			
			else if((i%5)==0)
			Console.WriteLine("Smallest Factor Of " + i +" Is 5");

			else if((i%7)==0)
			Console.WriteLine("Smallest Factor Of " + i +" Is 7");

			else
			Console.WriteLine(i+"Is  Not Divisible By 2,3,5,7");
		}
	}
}

			