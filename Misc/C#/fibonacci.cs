using System;
class fibonacci
{
	public static void Main()
	{
		int num1, num2,num3;
		num1=num2=1;
		Console.WriteLine("{0}", num1);
		for(num3=0; num3<10; num3++)
		{
			Console.WriteLine("{0}", num2);
			num2+=num1;
			num1=num2-num1;
		}
	}
}
