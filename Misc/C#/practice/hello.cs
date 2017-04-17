using System;
class hello
{
	public hello()
	{
		display();
	}
	public void display()
	{
		Console.WriteLine("Hello");
	}
}
class hello1
{
	public static void Main()
	{
		hello h=new hello();
	}
}