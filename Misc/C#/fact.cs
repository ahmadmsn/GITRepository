using System;
class factorial
{
	int n;
	public void acceptnum()
	{
		
		Console.WriteLine("Enter Number For Factorial");
		n=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Factorial Of  "+ n +"  Is");
	}
	public void operation()
	{
		
		for(int i=n-1; i>=1; i--)
		{
			n=n*i;
		}
		Console.WriteLine(n);
	}
	
}
class dispfactorial
{
	public static void Main(string [] args)
	{
		factorial f=new factorial();
		f.acceptnum();
		f.operation();
	}
}



		