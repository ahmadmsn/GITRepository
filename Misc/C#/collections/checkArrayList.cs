using System;
using System.Collections;
class checkArrayList : IComparer
{
	public int Compare(object obj1, object obj2)
	{
		checksort a, b;
		a = (checksort) obj1;
		b = (checksort) obj2;
		return a.name.CompareTo(b.name);
	}
}
class checksort
{
	public string name;
	int number;
	public checksort(string n,int i)
	{
		name=n;
		number=i;
	}
	public override string ToString()
	{
		return
		String.Format("Name {0,-10} Number: {1,6}", name, number);
	}
}
class demoArrayList
{	
	
	public static void Main()
	{
		checkArrayList comp=new checkArrayList();		
		ArrayList a1=new ArrayList();
		Console.WriteLine("Initial Number Of Elements"+a1.Count);
		
		//For user InterFace
		// For Infinite Loop for(;;)
		/*for (int i=0;i<5 ;i++)
		{
			Console.WriteLine("Enter Name");
			string na=Console.ReadLine();
			Console.WriteLine("Enter Number");
	 		int nb=Convert.ToInt32(Console.ReadLine());
			a1.Add(new checksort(na, nb));		
		}*/
		a1.Add(new checksort("Admiral", 55));
		a1.Add(new checksort("Sachin", 60));
		a1.Add(new checksort("Rani", 45));
		
		

		Console.WriteLine("Number Of Elements"+a1.Count);
		
		//q)Console.WriteLine(a1.IndexOf(60));
		
		Console.WriteLine(" Elements before Sorting");
		
		
		foreach(checksort j in a1)
		{
			Console.WriteLine("  "+j);
		}
		Console.WriteLine();
		//q)sachin is not remove
		a1.Remove("Sachin");
		Console.WriteLine("Number Of Elements"+a1.Count);
		a1.Sort(comp);
		//q)Console.WriteLine("Index Of Admiral"+a1.BinarySearch("Admiral"));

		Console.WriteLine(" Elements after Sorting");
		foreach(checksort j in a1)
		{
			Console.WriteLine("  "+j);
		}
		
		
		

		
		
	}	
}