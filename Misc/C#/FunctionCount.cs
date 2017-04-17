using System;
class FunctionCount
{
	public static int count=0;
	public static void countfunction()
	{
		count++;
		Console.WriteLine("Count Function is caleed by main{0}", count);
	}
	public static void Main(string [] args)
	{
		for(int var=0; var<10; var++)
		{
			FunctionCount.countfunction();
		}	
		Console.ReadLine();
	}
}