using System;
using System.Collections;
class compcheckenum:IComparer
{
	public int Compare(object obj1,object obj2)
	{
		checkenum a,b;
		a=(checkenum) obj1;
		b=(checkenum) obj2;
		//Console.WriteLine("comparing");
		return a.cost.CompareTo(b.cost);
	}
}

class checkenum
{
	public string name;
	public double cost;
	public checkenum(string n,double c)
	{
		name=n;
		cost=c;
	}
	public override string ToString()
	{
		return
			String.Format("{0,-10} cost:{1,6:C}",name,cost);
	}
}
class checkenumdemo
{
	public static void Main()
	{
		compcheckenum comp=new compcheckenum();
		ArrayList a=new ArrayList();
		a.Add(new checkenum("Adams",2.25));
		a.Add(new checkenum("Babu",3.25));
		a.Add(new checkenum("Rani",10.69));
		a.Add(new checkenum("hello",3.25));
		Console.WriteLine("Show All List");
		Console.WriteLine("Before Sorting");
		foreach(checkenum i in a)
		{
			Console.WriteLine(i);
		}
		Console.WriteLine();
		a.Sort(comp);
		Console.WriteLine("After Sorting");
		foreach(checkenum i in a)
		{
			Console.WriteLine(i);
		}
	}
}
			