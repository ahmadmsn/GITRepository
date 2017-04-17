using System;
class optroverlddemo
{
	int x,y,z;
	public optroverlddemo()
	{
		x=y=z=0;
	}
	public optroverlddemo(int i,int j, int k)
	{
		x=i;
		y=j;
		z=k;
	}
	public  optroverlddemo operator + (optroverlddemo a, optroverlddemo b)
	{
		optroverlddemo r=new optroverlddemo();
		r.x = a.x + b.x;
		r.y = a.y + b.y;
		r.z = a.z + b.z;
	
		return r;
	}
	public static optroverlddemo operator - (optroverlddemo a, optroverlddemo b)
	{
		optroverlddemo r=new optroverlddemo();
		r.x = a.x - b.x;
		r.y=a.y - b.y;
		r.z=a.z - b.z;
		return r;
	}
		
	public void show()
	{
		Console.Write("x is: "+x+ " y is: "+y+ " z is:" +z);
		Console.WriteLine();
	}
}
class demo
{
	public static void Main()
	{
		optroverlddemo o=new optroverlddemo(1,2,3);
		optroverlddemo o1=new optroverlddemo(4,5,6);
		optroverlddemo o2=new optroverlddemo();
		o.show();
		o1.show();
		o2=o+o1;
		o2.show();
		o2=o1-o;
		o2.show();
	}
}
			

