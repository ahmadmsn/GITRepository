using System;
class reversenumber
{
	public static void Main()
	{
		int num;
		int nextdigit;
		num=198;
		Console.WriteLine("Number"+num);
		Console.Write("Number In Reverse Order");
		do
		{
			nextdigit=num%10;
			Console.Write(nextdigit);
			num=num/10;
			
		}
		while(num>0);
	}
}
		
	