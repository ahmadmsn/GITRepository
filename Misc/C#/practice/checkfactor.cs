using System;
class facto
{
	public static void Main()
	{
		int i;
		int num;
		Console.WriteLine("Enter Number");
		num=Convert.ToInt32(Console.ReadLine());
		for(i=2; i<=num;i++)
		{
			if(num%i==0)
			Console.WriteLine(i);
		}
	}
}