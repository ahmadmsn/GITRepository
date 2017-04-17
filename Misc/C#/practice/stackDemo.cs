using System;
using System.Collections;
class stackDemo
{
	static void showPush(Stack st, int a)
	{
		st.Push(a,b);
		Console.WriteLine("Push (" +a ")");
		foreach(int i in st)
		Console.Write(i+ "  ");
		Console.WriteLine();
	}
	static void showPop(Stack st)
	{
		Console.Write("Pop->");
		int a=(int) st.Pop();
		int b=(int)st.Pop();
		Console.WriteLine(a);
		Console.Write("Stack");
		foreach(int i in st)
		Console.Write(i+ "  ");
		Console.WriteLine();
	}
	public static void Main()
	{
		Stack st=new Stack();
		//foreach(int i in st)
		//Console.WriteLine(i +  "  ");
		showPush(st,22);
		showPush(st,65);
		showPush(st,91);
		showPop(st);
		showPop(st);
		showPop(st);
		
		try
		{
			showPop(st);
		}
		catch(InvalidOperationException)
		{
			Console.WriteLine("Stack Empty");
		}
	}
}
	