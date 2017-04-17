using System;
class factorial
{
	public static void Main()
	{
		int number;
		Console.WriteLine("Enter Number");
		number=Convert.ToInt32(Console.ReadLine());
		for(int i=number-1; i>1;i--)
		{
			number=i*number;
		}
		Console.WriteLine(number);
	}
}