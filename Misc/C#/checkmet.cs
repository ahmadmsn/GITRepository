using System;
class checkmet
{
	void addone(int var)
	{
		var++;
	}
	public static void Main(string [] args)
	{
		checkmet c=new checkmet();
		int number=6;
		c.addone(number);
		Console.WriteLine(number);
	}
}