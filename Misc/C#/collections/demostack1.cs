using System;
using System.Collections;
class demostack1
{
	public static void showpush(Stack st,int a)
	{
		st.Push(a);
		Console.WriteLine("Push ( "+a+ ")");
		
		Console.Write("Stack: ");
		foreach(int i in st)
		{
			Console.Write(i+ " ");
		}
		Console.WriteLine();
	}
	public static void showpop(Stack st)
	{
		Console.WriteLine("Pop :=>");
		int a=(int) st.Pop();
		Console.WriteLine(a);
		
		Console.Write("Stack :");
		foreach(int j in st)
		{
			Console.Write(j+ " ");
		}
		Console.WriteLine();
	}
}
class demo
{
	public static void Main()
	{
		demostack1 d=new demostack1();
		Stack st=new Stack();
		d.showpush(st,2);
		d.showpush(st,3);
		d.showpush(st,5);
		d.showpush(st,7);
		d.showpush(st,1);
		d.showpush(st,8);
		d.showpop(st);
		d.showpop(st);
		d.showpop(st);
		d.showpop(st);
		d.showpop(st);
		d.showpop(st);
		try
		{
			d.showpop(st);
		}
		catch(InvalidOperationException)
		{
			Console.WriteLine("Stack Empty");
		}
	}
}
			