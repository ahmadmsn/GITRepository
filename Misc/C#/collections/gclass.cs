using System;
using System.Collections.Generic;
class gclass<T>
{
	public T a;
	public gclass(T b)
	{
		a=b;
	}
	public T show
	{
		get
		{
			return a;
		}
		set
		{
			a=value;
		}
	}
}
class demo
{
	public static void Main()
	{
		gclass<int> g=new gclass<int>(2);
		gclass<string> s=new gclass<string> ("Hello");
		Console.WriteLine(g.show);
		Console.WriteLine(s.show);
	}
}
	