using System;
class Factorial1
{
	public static void Main(string [] args)
	{
		int number;
		//int num1;
		//num1=1;
		Console.WriteLine("Enter Number");
		number=Convert.ToInt32(Console.ReadLine());
		for(int i=number-1; i>=1; i--)
		{
			number=number*i;
		}
		Console.WriteLine(number);
	}
}	