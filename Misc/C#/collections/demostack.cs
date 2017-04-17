using System;
using System.Collections;
class demostack
{
	public static void Main()
	{
		Stack st=new Stack();
		st.Push(1);
		st.Push(2);
		st.Push(3);
		st.Push(4);
		foreach(int i in st)
		{
			Console.WriteLine(i);
		}
		Console.WriteLine("Now Pop");
		for(int k=1;k<st.Count;k++)
		{
			st.Pop();
			foreach(int j in st)
			{
				if ( j != 0)
				Console.WriteLine(j);
			}
		}
		
		/*st.Pop();
		foreach(int j in st)
		{
			Console.WriteLine(j);
		}*/
		
	}
}