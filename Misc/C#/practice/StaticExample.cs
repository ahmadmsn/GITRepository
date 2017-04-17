using System;
class StaticExample
{
	public static int s;
	public void count()
	{
		s++;
	}
	public int display()
	{
		return s;
	}
	
}
class Static 
{
	static int Main(string [] args)
	{
		StaticExample s=new StaticExample();
		StaticExample s2=new StaticExample();
		s.count();
		s.count();
		s.count();
		Console.WriteLine("The Value of variable is {0}", s2.display());
		Console.ReadLine();
		return 0;
	}
}

