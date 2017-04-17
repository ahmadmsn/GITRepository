using System;
using System.Collections;
class programme
{
	public static void Main()
	{
		ArrayList a=new ArrayList();
		ArrayList b=new ArrayList();
		
		
		a.Add("HELLO");
		a.Add("DAY");
		a.Add("NIGHT");
		a.Add("NIGHT");
		a.Add("NIGHT");
		a.Add("MOON");
		string [] ar=new string[10];
		/*Console.WriteLine((int)a[0]);
		Console.WriteLine((string)a[1]);
		Console.WriteLine((float)a[2]);
		a.TrimToSize();		
		Console.WriteLine(a.Capacity);
		Console.WriteLine(a.Count);*/
		/*a.Remove("HELLO");
		//a.Remove("HELLO");
		//a.TrimToSize();
		//Console.WriteLine(a.Capacity);
		Console.WriteLine(a.Count);*/
		a.CopyTo(ar);
		//a.CopyTo(2,ar,0,a.Count);
		Console.WriteLine(ar.Length);
		foreach(string i in ar)
		{
			Console.WriteLine(i);
		}
		
		a.Sort();
		//b=ArrayList.ReadOnly(a);
		//a.Reverse();
		foreach(string i in a)
		{
			Console.WriteLine(i);
		}
		Console.WriteLine("Index of Night Is"+a.IndexOf("NIGHT"));
		Console.WriteLine("Index of Night Is"+a.BinarySearch("NIGHT"));
		Console.WriteLine("Index of Night Is"+a.LastIndexOf("NIGHT"));
		//a.InsertRange(3,"Hi");
		//b.Add("Day");
		//Console.WriteLine("Index of Day :" +b.IndexOf("Day"));
	}
}