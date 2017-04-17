using System;
using System.Collections;
class size
{
	public static void Main()
	{
		ArrayList a1 = new ArrayList();
		Console.WriteLine("Capacity Is:" +a1.Capacity);
		Console.WriteLine("Count Is:" +a1.Count);
		for(int i=0;i<5;i++)
		{
			a1.Add((int) (1+i));
		}
		Console.WriteLine("Capacity Is:" +a1.Capacity);
		Console.WriteLine("Count Is:" +a1.Count);
	}
}