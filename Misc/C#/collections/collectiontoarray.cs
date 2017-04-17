using System;
using System.Collections;
class collectiontoarray
{
	public static void Main()
	{
		ArrayList a1 = new ArrayList();
		for ( int i=0; i<5;i++)
		{
			a1.Add((int) (1+i));
		}
		foreach(int number in a1)
		{
			Console.WriteLine("Number Is  {0}",number);
		}
		int [] ar= (int[]) a1.ToArray(typeof(int));
		Console.WriteLine("Length of:"+ar.Length);
		for(int j=0;j<ar.Length;j++)
		{
			Console.WriteLine(ar[j]);
		}
	}
}