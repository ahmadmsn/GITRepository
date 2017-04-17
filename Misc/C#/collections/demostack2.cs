using System;
using System.Collections;
class demostack2
{
	public static void Main()
	{
		Stack s1=new Stack();
		for(int i=0;i<5;i++)
		{
			s1.Push((int)(1+i));
		}
		foreach(int i in s1)
		{
			Console.WriteLine(i);
		}
		int len=s1.Count;
		for(int j=0;j<len;j++)
		{
			Console.WriteLine(s1.Pop());
		}
	}
}