using System;
class reverse
{
	char [] number=new char[10];
	public void accept()
	{
		Console.WriteLine("Enter Number");
		number=Console.ReadLine().ToCharArray();
	}
	public void operation()
	{
		int val=number.Length;
		//Console.WriteLine(number[1]);	
		for (int i=val-1;i>=0;i--)
		{
			Console.Write(number[i]);	
		}
		//Console.WriteLine(val);
	}
	public static void Main(string [] args)
	{
		reverse r=new reverse();
		r.accept();
		r.operation();
	}
}
		

	