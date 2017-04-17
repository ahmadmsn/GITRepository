using System;
using System.Collections;
class sorting
{
	public static void Main()
	{
		SortedList s1=new SortedList();
		s1.Add("house","Dwelling");
		s1.Add("car","transport");
		s1.Add("book","printed words");
		s1.Add("apple","fruit");
		s1["tractor"]="farmer";
		ICollection c=s1.Keys;
		Console.WriteLine("Contents with Indexer");
		foreach(string i in c)
		{
			Console.WriteLine(i+" : "+s1[i]);
		}
		Console.WriteLine("Contents with Their position 0 to...");
		for(int i=0;i<s1.Count;i++)
		{
			Console.WriteLine(s1.GetByIndex(i));
		}
		Console.WriteLine("Third Key Is"+s1.GetKey(3));
	}
}
		