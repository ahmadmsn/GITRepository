using System;
class even
{
	public static void Main(string [] args)
	{
		int i;
		int k;
		Console.WriteLine("Enter number for even till u want");
		i=Convert.ToInt32(Console.ReadLine());
		for(k=0; k<i; k++)
		{
			if(k%2 == 0)
			Console.WriteLine(k);
		}
		
	}
}
				
				

				