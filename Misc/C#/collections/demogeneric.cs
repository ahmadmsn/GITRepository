using System;
using System.Collections.generic;
class genericdemo
{
	public static void Main()
	{
		List<int> l1=new List<int>();
		Console.WriteLine("Initial number Of elements"+l1.Count);
		l1.Add(1);
		l1.Add(2);
		l1.Add(3);
		Console.WriteLine("After Adding 3 elements:"+l1.Count);
		Console.WriteLine("Current Contents:");
		foreach(int i in l1)
		{
			Console.WriteLine(i);
		}
	}
}
		