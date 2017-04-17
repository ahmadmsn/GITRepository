using System;
using System.Collections;
class checkcollection
{
	string name;
	double cost;
	int onhand;
	public checkcollection(string n,double c,onhand o)
	{
		name=n;
		cost=c;
		onhand=o;
	}
	public override string ToString()
	{
		return
			String.Format("{0,-10}cost:{1,6:C} on hand: {2}",name,cost,onhand);
	}
}
class checkcollectiondemo
{
	public static void Main()
	{
		ArrayList a=new ArrayList();
		a.Add(new checkcollection("Pliers",5.95,3));
		a.Add(new checkcollection("Wrenches",8.29,2));
		a.Add(new checkcollection("Hammers",3.50,4));
		a.Add(new checkcollection("Drills",19.88,8));
	
		Console.WriteLine(" Show All List");
		foreach(checkcollection i in a)
		{
			Console.WriteLine(" "+i);
		}
	}
}	