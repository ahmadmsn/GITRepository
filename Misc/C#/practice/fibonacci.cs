using System;
class fibonacci
{
	public static void Main()
	{
		
		int number;
		int num1,num2;
		num1=num2=1;
		Console.WriteLine("Enter Number");
		number=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(num1);
		for(int i=0; i<=number;i++)
		{
			Console.WriteLine(num2);	
			num2=num1+num2;
			num1=num2-num1;	
		}
		Console.WriteLine(num2);
	}
}
		
		