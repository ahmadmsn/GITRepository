using System;
class cde
{
	int i,result;
	public void accept()
	{
		Console.WriteLine("Enter number");
		i=Convert.ToInt32(Console.ReadLine());
	}
	public void operation()
	{
		result=2*i;
		Console.WriteLine(result);
	}
}
class abc
{
	public static void Main()
	{
		cde c=new cde();
		c.accept();
		c.operation();
	}
}
		