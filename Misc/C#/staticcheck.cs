using System;
class staticcheck
{
	static void Main(string [] args)
	{
		staticexample.ivar=1;
		Console.WriteLine(staticexample.ivar.ToString());
		Console.ReadLine();
	}
}
public class staticexample
{
	public static int ivar;
		staticexample()
		{
			Console.WriteLine("Object Created");
		}
}
