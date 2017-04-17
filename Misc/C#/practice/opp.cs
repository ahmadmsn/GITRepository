using System;
class opp
{	
	
	public static void Main(string [] args)
	{
		int i;
		int j;
		int number;
		Console.WriteLine("Enter Number");
		number=Convert.ToInt32(Console.ReadLine());
		
		for(i=1; i<=number; i++)
		{
			//Console.Write(i);
			for(int x=1;x<=number;x++)
				Console.Write(" ");	
			for(j=1; j<=i; j++)
			{					
				Console.Write(j);
			}
			Console.Write("\n");
			//Console.Write(j);			
		}
		
	}
}