using System;
class fact3
{	int number;
	public void accept()
	{
		Console.WriteLine("Enter Number");
		number=Convert.ToInt32(Console.ReadLine());
	}
	public void operation()
	{
		for(int x=number-1; x>=1; x--)
		{
			number=x*number;
		}
		Console.WriteLine(number);
	}
}
class main
{
	public static void Main(string [] args)
	{
		fact3 f=new fact3();
		f.accept();
		f.operation();
	}
}