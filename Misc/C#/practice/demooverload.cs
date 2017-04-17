using System;
class demooverload
{
	int x,y;
	public demooverload()
	{
		x=y=0;
	}
	public demooverload(int i, int j)
	{
		x=i;
		y=j;
	}
	public static demooverload add(demooverload a, demooverload b)
	{
		demooverload d=new demooverload();
		d.x=a.x+b.x;
		d.y=a.y+b.y;
		
		return d;
	}
	public void show()
	{
		Console.WriteLine("X is " +x+ " Y is "+y);
	}
}
class demo
{
	public static void Main()
	{
		demooverload m=new demooverload(2,2);
		demooverload m1=new demooverload(3,3);
		demooverload m2=new demooverload();
		m.show();
		m1.show();
		m2=demooverload.add(m,m1);
		m2.show();
	}
}
		
	