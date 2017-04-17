using System;
class primenumber
{
	public static void Main(string [] args)
	{
		int num;
		int temp=0;
		Console.WriteLine("Enter The number");
		num=Convert.ToInt32(Console.ReadLine());
		for(int x=3; x<=num; x++)
		{
			int counter=0;
			for(int y=2; y<x; y++)
			{
				temp=x%y;			
				if(temp==0)
				counter=counter+1;		
			}
			if(counter==0)
			{
				Console.WriteLine(x+"is prime");		
			}		
					
		}		
			
	}
}