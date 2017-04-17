using System;
class swap1
{
	public void swap(int a, int b)
	{
		Console.WriteLine("earlier value of a and b");
		Console.WriteLine("{0},{1}",a,b);
		int t;
		t=a;
		a=b;
		b=t;
		Console.WriteLine("After swapping");
		Console.WriteLine("{0},{1}",a,b);
	}
	
}
class swapdemo
{
	public static void Main()
	{
		swap1 s=new swap1();	
		
	
		//a=10;
		//b=20;
		s.swap(10,20);
		
	}
}
		
		