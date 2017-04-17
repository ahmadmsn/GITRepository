using System;
class check1
{
	public static void Main(string [] args)
	{
		int num;
		Console.WriteLine("Enter Your Number");
		num=Convert.ToInt32(Console.ReadLine());
		if(num % 2 == 0)
		{
			Console.WriteLine("Number is Even");
		}
		else
		{
			Console.WriteLine("Number Is Odd");
		}
	}
}