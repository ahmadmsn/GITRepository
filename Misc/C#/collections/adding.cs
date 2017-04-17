using System;
using System.Collections;
class adding
{
	public static void Main()
	{
		ArrayList a1=new ArrayList();
		for(int i=0; i<5; i++)
		{
			a1.Add((char) ('a' + i));
		}
		foreach(char j in a1)
		{
			Console.WriteLine(j);
		}
	}
}