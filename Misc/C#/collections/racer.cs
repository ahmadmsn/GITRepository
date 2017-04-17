using System;
using System.Collections.Generic;
class racer
{
	private string name;
	public string rname
	{
		get
		{
			return name;
		}
		set
		{
			name=value;
		}
	}
	private string car;
	public string rcar
	{
		get
		{
			return car;
		}
	}
	public racer(string name, string car)
	{
		this.name=name;
		this.car=car;
	}
	public override string ToString()
	{
		return name+","+car;
	}
}
class demo
{
	public static void Main()
	{
		List<racer> r=new List<racer>();
		r.Add(new racer("Addy","Maruti"));
		foreach(racer a in r)
		{
			Console.WriteLine(a);
		}
	}
}

